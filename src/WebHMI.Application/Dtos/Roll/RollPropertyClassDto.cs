using System;
using WebHMI.Interface;

namespace WebHMI.Dtos.Roll
{
    public class RollPropertyClassDto : IAuditLogRelatedIdGetter
    {
        public int RollPropertyClass { get; set; }
        public double? CwIn { get; set; }
        public double? CwOut { get; set; }
        public double? DensityIn { get; set; }
        public double? DensityOut { get; set; }
        public string Description { get; set; }
        public double? EmodIn { get; set; }
        public double? EmodOut { get; set; }
        public double? ExpansionCoefIn { get; set; }
        public double? ExpansionCoefOut { get; set; }
        public double? HtEnv { get; set; }
        public double? HtEnv2 { get; set; }
        public double? HtNeck { get; set; }
        public double? LambdaIn { get; set; }
        public double? LambdaOut { get; set; }
        public string PlantType { get; set; }
        public int? RollMatType { get; set; }
        public string RollType { get; set; }
        public double? TInit { get; set; }
        public double? TNeck { get; set; }
        public double? TNeckMax { get; set; }
        public double? WEffBotRoll { get; set; }
        public double? WEffTopRoll { get; set; }
        public double? YieldPolynomCInd0 { get; set; }
        public double? YieldPolynomCInd1 { get; set; }
        public double? YieldPolynomCInd2 { get; set; }
        public double? YieldPolynomCInd3 { get; set; }
        public double? YieldStress { get; set; }
        public string Mop { get; set; }
        public DateTime? Toc { get; set; }
        public DateTime? Tom { get; set; }

        public string GetAuditLogRelatedId()
        {
            return $"{RollPropertyClass}";
        }
    }
}
