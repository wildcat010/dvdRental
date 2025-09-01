using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Runtime.Session;
using Abp.Application.Services.Dto;
using Abp.Linq;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using WebHMI.Filters;
using Abp.Linq.Extensions;
using System.Linq.Dynamic.Core;
using WebHMI.MultiTenancy;
using WebHMI.Authorization.Users;
using WebHMI.WebHMI.Dbo;
using System.Collections.Generic;

namespace WebHMI.Helpers
{
	/// <summary>
	/// Derive your application services from this class.
	/// </summary>
	public abstract class ApplicationServiceBase : ApplicationService
	{
		public UserManager UserManager { get; set; }

		protected virtual async Task<User> GetCurrentUserAsync()
		{
			var user = await UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
			if (user == null)
			{
				throw new Exception("There is no current user!");
			}

			return user;
		}

		protected static async Task<PagedResultDto<TEntity>> ApplyFilterWithoutMapping<TEntity>(IQueryable<TEntity> query, FilteredRequestDto input)
		{
			query = ApplySorting(query, input);
			query = ApplyFilters(query, input);

			var totalCount = query.Count();

			query = ApplyPaging(query, input, totalCount);

			var entities = await query.ToListAsync();

			return new PagedResultDto<TEntity>(
				totalCount,
				entities
			);
		}

		public static async Task<PagedResultDto<TEntityDto>> ApplyFilter<TEntity, TEntityDto>(IQueryable<TEntity> query, FilteredRequestDto input, Func<TEntity, TEntityDto> map)
		{
			query = ApplySorting(query, input);
			query = ApplyFilters(query, input);

			var totalCount = await query.CountAsync();

			query = ApplyPaging(query, input, totalCount);

			var entities = await query.ToListAsync();

			return new PagedResultDto<TEntityDto>(
				totalCount,
				entities.Select(map).ToList()
			);
		}

        protected Task<PagedResultDto<TEntityDto>> ApplyFilter<TEntity, TEntityDto>(IQueryable<TEntity> query, FilteredRequestDto input)
        {
            return ApplyFilter(query, input, MapToEntityDto<TEntity, TEntityDto>);
        }

        protected PagedResultDto<TEntityDto> ApplyFilter<TEntity, TEntityDto>(IEnumerable<TEntity> list, FilteredRequestDto input, Func<TEntity, TEntityDto> map)
        {
            var query = list.AsQueryable();

            query = ApplySorting(query, input);
            query = ApplyFilters(query, input);

            var totalCount = query.Count();

            query = ApplyPaging(query, input, totalCount);

            var entities = query.ToList();

            return new PagedResultDto<TEntityDto>(
                totalCount,
                entities.Select(map).ToList()
            );
        }

        private static IQueryable<TEntity> ApplyFilters<TEntity>(IQueryable<TEntity> query, FilteredRequestDto input)
		{
			if (input.Filter != null)
			{
				var predicate = new DynamicFilterBuilder<TEntity>();

				BuildFilter(predicate, input.Filter);

				return query.Where(predicate.Build());
			}

			//No filtering
			return query;
		}

		private static void BuildFilter<TEntity>(DynamicFilterBuilder<TEntity> action, Filter filter)
		{
			var t = typeof(TEntity).GetProperty(filter.Field,
				BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance).PropertyType;

			if (GenericTryParse(filter.Value, t, out object value, filter.Operator))
			{
				switch (filter.Logic)
				{
					case FilterLogic.And:
						action = action.And(filter.Field, filter.Operator, value);
						break;
					case FilterLogic.Or:
						action = action.Or(filter.Field, filter.Operator, value);
						break;
				}
			}

			if (filter.Filters != null)
			{
				foreach (var sub in filter.Filters)
				{
					switch (filter.Logic)
					{
						case FilterLogic.And:
							action = action.And(b => BuildFilter(b, sub));
							break;
						case FilterLogic.Or:
							action = action.Or(b => BuildFilter(b, sub));
							break;
					}
				}
			}
		}

		private static IQueryable<TEntity> ApplySorting<TEntity>(IQueryable<TEntity> query, FilteredRequestDto input)
		{
			if (input?.Sort?.Any() ?? false)
			{
				var ordering = string.Join(",", input.Sort.Select(s => $"{s.Field} {s.Dir}"));
				return query.OrderBy(ordering);
			}

			//No sorting
			return query;
		}

		private static IQueryable<TEntity> ApplyPaging<TEntity>(IQueryable<TEntity> query, FilteredRequestDto input, int totalCount)
		{
			//Try to use paging if available
			var pagedInput = input as IPagedResultRequest;
			if (pagedInput != null)
			{
                pagedInput.MaxResultCount = pagedInput.MaxResultCount == 0 ? totalCount : pagedInput.MaxResultCount;
                return query.PageBy(pagedInput);
			}

			//Try to limit query result if available
			var limitedInput = input as ILimitedResultRequest;
			if (limitedInput != null)
			{
				return query.Take(limitedInput.MaxResultCount);
			}

			//No paging
			return query;
		}

		private static bool GenericTryParse(string input, Type t, out object value, FilterOperator op)
		{
			if ((op == FilterOperator.Equals || op == FilterOperator.DoesntEqual) && input is null)
			{
				value = null;
				return true;
			}

			if (input == null)
			{
				value = null;
				return false;
			}

			var converter = TypeDescriptor.GetConverter(t);

			if (op == FilterOperator.InList || op == FilterOperator.NotInList)
			{
				var parts = input.Split(',');
				if (parts.Length > 0)
				{
					var values = Array.CreateInstance(t, parts.Length);

					for (int i = 0; i < parts.Length; i++)
					{
						string part = parts[i];
						if (converter != null && converter.IsValid(part))
						{
							values.SetValue(converter.ConvertFromString(part), i);
						}
						else
						{
							value = input;
							return false;
						}
					}

					value = values;
					return true;
				}
			}

			if (t == input.GetType())
			{
				value = input;
				return true;
			}

			if (converter != null && converter.IsValid(input))
			{
				value = converter.ConvertFromString(input);
				return true;
			}

			value = input;
			return false;
		}

        protected TEntityDto MapToEntityDto<TEntity, TEntityDto>(TEntity entity)
        {
            return ObjectMapper.Map<TEntityDto>(entity);
        }
    }
}


