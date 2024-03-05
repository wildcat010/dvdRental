using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WebHMI.Dtos;

namespace WebHMI.Filters
{
	public static class DynamicExpression
    {
        private static readonly Type _stringType = typeof(string);
        private static readonly Type _enumerableType = typeof(IEnumerable<>);
        private static readonly Type _dictionaryType = typeof(IDictionary<,>);

        private static readonly MethodInfo _toStringMethod = typeof(object).GetMethod("ToString");

        private static readonly MethodInfo _stringContainsMethod = typeof(string).GetMethod("Contains", new Type[] { typeof(string) });
        private static readonly MethodInfo _enumerableContainsMethod = typeof(Enumerable).GetMethods().Where(x => string.Equals(x.Name, "Contains", StringComparison.OrdinalIgnoreCase)).Single(x => x.GetParameters().Length == 2).MakeGenericMethod(typeof(string));

        private static readonly MethodInfo _dictionaryContainsKeyMethod = typeof(Dictionary<string, string>).GetMethods().Where(x => string.Equals(x.Name, "ContainsKey", StringComparison.OrdinalIgnoreCase)).Single();
        private static readonly MethodInfo _dictionaryContainsValueMethod = typeof(Dictionary<string, string>).GetMethods().Where(x => string.Equals(x.Name, "ContainsValue", StringComparison.OrdinalIgnoreCase)).Single();

        private static readonly MethodInfo _endsWithMethod = typeof(string).GetMethod("EndsWith", new Type[] { typeof(string) });

        private static readonly MethodInfo _isNullOrEmtpyMethod = typeof(string).GetMethod("IsNullOrEmpty", new Type[] { typeof(string) });

        private static readonly MethodInfo _startsWithMethod = typeof(string).GetMethod("StartsWith", new Type[] { typeof(string) });

        public static Expression<Func<TEntity, bool>> GetPredicate<TEntity>(string property, FilterOperator op, object value)
        {
            var param = Expression.Parameter(typeof(TEntity));
            return Expression.Lambda<Func<TEntity, bool>>(GetFilter(param, property, op, value), param);
        }

        public static Expression<Func<TEntity, object>> GetPropertyGetter<TEntity>(string property)
        {
            if (property == null)
                throw new ArgumentNullException(nameof(property));

            var param = Expression.Parameter(typeof(TEntity));
            var prop = param.GetNestedProperty(property);
            var convertedProp = Expression.Convert(prop, typeof(object));
            return Expression.Lambda<Func<TEntity, object>>(convertedProp, param);
        }

        internal static Expression GetFilter(ParameterExpression param, string property, FilterOperator op, object value)
        {
            var prop = param.GetNestedProperty(property);
            ConstantExpression constant = null;

            if (value is null)
                constant = Expression.Constant(null, prop.Type);
            else if (value.GetType().GetElementType() == prop.Type) // enumerables and arrays
                constant = Expression.Constant(value, value.GetType());
            else if (value.GetType().IsAssignableTo(prop.Type)) //nullables and primitives
                constant = Expression.Constant(value, prop.Type);

            return CreateFilter(prop, op, constant);
        }

        private static Expression CreateFilter(MemberExpression prop, FilterOperator op, ConstantExpression constant)
        {
            return op switch
            {
                FilterOperator.Equals => RobustEquals(prop, constant),
                FilterOperator.GreaterThan => Expression.GreaterThan(prop, constant),
                FilterOperator.LessThan => Expression.LessThan(prop, constant),
                FilterOperator.Contains => GetContainsMethodCallExpression(prop, constant),
                FilterOperator.NotContains => Expression.Not(GetContainsMethodCallExpression(prop, constant)),
                FilterOperator.ContainsKey => Expression.Call(prop, _dictionaryContainsKeyMethod, PrepareConstant(constant)),
                FilterOperator.NotContainsKey => Expression.Not(Expression.Call(prop, _dictionaryContainsKeyMethod, PrepareConstant(constant))),
                FilterOperator.ContainsValue => Expression.Call(prop, _dictionaryContainsValueMethod, PrepareConstant(constant)),
                FilterOperator.NotContainsValue => Expression.Not(Expression.Call(prop, _dictionaryContainsValueMethod, PrepareConstant(constant))),
                FilterOperator.StartsWith => Expression.Call(prop, _startsWithMethod, PrepareConstant(constant)),
                FilterOperator.EndsWith => Expression.Call(prop, _endsWithMethod, PrepareConstant(constant)),
                FilterOperator.DoesntEqual => Expression.Not(RobustEquals(prop, constant)),
                FilterOperator.GreaterThanOrEqual => Expression.GreaterThanOrEqual(prop, constant),
                FilterOperator.LessThanOrEqual => Expression.LessThanOrEqual(prop, constant),
                FilterOperator.IsEmpty => Expression.Call(_isNullOrEmtpyMethod, prop),
                FilterOperator.IsNotEmpty => Expression.Not(Expression.Call(_isNullOrEmtpyMethod, prop)),
                FilterOperator.InList => GetContainsMethodCallExpression(prop, constant),
                FilterOperator.NotInList => Expression.Not(GetContainsMethodCallExpression(prop, constant)),
            _ => throw new NotImplementedException()
            };
        }

        private static Expression RobustEquals(MemberExpression prop, ConstantExpression constant)
        {
            if (prop.Type == typeof(bool) && bool.TryParse(constant.Value.ToString(), out var val))
            {
                return Expression.Equal(prop, Expression.Constant(val));
            }

            return Expression.Equal(prop, constant);
        }

        private static Expression GetContainsMethodCallExpression(MemberExpression prop, ConstantExpression constant)
        {
            if (prop.Type == _stringType)
                return Expression.Call(prop, _stringContainsMethod, PrepareConstant(constant));
            else if (prop.Type.HasGenericInterface(_dictionaryType))
                return Expression.Or(Expression.Call(prop, _dictionaryContainsKeyMethod, PrepareConstant(constant)), Expression.Call(prop, _dictionaryContainsValueMethod, PrepareConstant(constant)));
            else if (prop.Type.HasGenericInterface(_enumerableType))
                return Expression.Call(_enumerableContainsMethod, prop, PrepareConstant(constant));
            else if (constant.Type.HasGenericInterface(_enumerableType))
            {
                MethodInfo _enumerableContainsMethod =
                    typeof(Enumerable).GetMethods()
                    .Where(x => string.Equals(x.Name, "Contains", StringComparison.OrdinalIgnoreCase))
                    .Single(x => x.GetParameters().Length == 2)
                    .MakeGenericMethod(constant.Type.GetElementType());
                return Expression.Call(_enumerableContainsMethod, constant, prop);

            }

            throw new NotImplementedException($"{prop.Type} contains is not implemented.");
        }

        public static bool HasGenericInterface(this Type @type, Type genericInterface)
        {
            var allInterfaces = @type.GetInterfaces();
            return allInterfaces
                .Where(i => i.IsGenericType)
                .Select(i => i.GetGenericTypeDefinition())
                .Any(i => i.IsAssignableFrom(genericInterface));
        }

        private static Expression PrepareConstant(ConstantExpression constant)
        {

            if (constant.Type == _stringType)
                return constant;

            var convertedExpr = Expression.Convert(constant, typeof(object));
            return Expression.Call(convertedExpr, _toStringMethod);
        }
    }
}
