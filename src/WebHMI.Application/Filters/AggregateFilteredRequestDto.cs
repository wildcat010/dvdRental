using System;
using System.Collections.Generic;
using WebHMI.Filters;

namespace WebHMIApplication.Dtos.Filters
{
    public class AggregateFilteredRequestDto : FilteredRequestDto
    {
        public AggregateFromToFilter FromToFilters { get; set; }
        public AggregatePlanFilter PlanFilter { get; set; }
    }

    public class AggregateFromToFilter
    {
        /// <summary>
        /// Name of the property for range filter (without 'from' and 'to' suffixes)
        /// </summary>
        public List<string> PropName { get; set; }

        /// <summary>
        /// Checks whether the value is within the range specified in the <see cref="PropName"/> columns 
        /// </summary>
        public List<double> Value { get; set; }
    }

    public class AggregatePlanFilter
    {
        /// <summary>
        /// Plan column names. Use only these you want to filter.
        /// </summary>
        public List<string> PropNames { get; set; } = new();

        /// <summary>
        /// Plan number value. Checks if it's used in the columns specified in the <see cref="PropNames"/> list
        /// </summary>
        public int Value { get; set; }
    }
}
