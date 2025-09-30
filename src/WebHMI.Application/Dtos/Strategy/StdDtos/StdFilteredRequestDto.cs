using WebHMI.Filters;

namespace WebHMI.Dtos.Strategy.StdDtos
{
    public class StdFilteredRequestDto : FilteredRequestDto
    {
        /// <summary>
        /// Used to filter 'Plans Without Assignment'. Returns all if false
        /// </summary>
        public bool NotAssignedPlans { get; set; }
    }
}
