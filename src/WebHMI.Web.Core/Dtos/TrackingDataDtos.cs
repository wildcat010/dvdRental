using System.Collections.Generic;
using System.Linq;
using XIDL;

namespace WebHMI.Dtos.Core.Communication
{
    public class MeasurementCache
    {
        public List<NamePassNoMeasurements> NameMeasurementsPairs { get; set; } = new();
        public List<HmiSingleMeasuredValue> GetMeasuredValuesByNamePassNo(string name, short passno)
            => NameMeasurementsPairs.FirstOrDefault(x => x.PassNo == passno && x.Name == name)?.MeasuredValues;
    }

    public class NamePassNoMeasurements
    {
        public List<HmiSingleMeasuredValue> MeasuredValues { get; set; } = new();
        public string Name { get; set; }
        public int PassNo { get; set; }
    }
    public record MeIdMatTypeKey(int meid, string matType);
}
