using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebHMI.Filters
{
	public class FilteredRequestDto : IPagedResultRequest
	{
		public virtual int SkipCount { get; set; }
		public virtual int MaxResultCount { get; set; }
		public IEnumerable<Sort> Sort { get; set; }
		public Filter Filter { get; set; }
	}

	public class Sort
	{
		public string Field { get; set; }
		public SortDirection Dir { get; set; }
	}

	public enum SortDirection
	{
		Asc,
		Desc
	}

	public class Filter
	{
		public string Field { get; set; }
		public FilterOperator Operator { get; set; }
		public string Value { get; set; }
		public FilterLogic Logic { get; set; }
		public IEnumerable<Filter> Filters { get; set; }
	}

	[JsonConverter(typeof(JsonStringEnumConverter))]
	public enum FilterLogic
	{
		And,
		Or
	}

	[JsonConverter(typeof(JsonStringEnumConverter))]
	public enum FilterOperator
	{
		Equals,
		DoesntEqual,
		GreaterThan,
		GreaterThanOrEqual,
		LessThan,
		LessThanOrEqual,
		Contains,
		NotContains,
		StartsWith,
		EndsWith,
		IsEmpty,
		IsNotEmpty,
		ContainsKey,
		NotContainsKey,
		ContainsValue,
		NotContainsValue,
		InList,
		NotInList
	}
}
