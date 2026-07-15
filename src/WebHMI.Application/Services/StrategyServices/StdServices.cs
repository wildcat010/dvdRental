using WebHMI.Dtos.Strategy.StdDtos;
using WebHMI.Dtos.Strategy.StdDtos.StdCSDtos;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.Mapping.Extensions;
using WebHMI.Mapping.Extensions.Strategy;
using WebHMI.Mapping.Extensions.Strategy.CSMappers;
using WebHMI.PRDB.Dbo;

namespace WebHMI.Services.StrategyServices
{
    public class StdLpPassService : StdPassService<
        StdLp, StdLpDto,
        StdLppass, StdLpPassDto>
    {
        public override string AggregateName => "FmLoadingPlan";

        public StdLpPassService() : base(
            StdLpMapper.ToDto,
            StdLpMapper.MapEntity,
            StdLpPassMapper.ToDto,
            StdLpPassMapper.MapEntity)
        { }
    }

    public class StdDrampHrmService : StdRampService<
    StdDphrm, StdDpRmDto,
    StdDprampHrm, StdDprampHrmDto>
    {
        public override string AggregateName => "RmDescalerPlan";

        public StdDrampHrmService() : base(
            StdDpHrmMapper.ToDto,
            StdDpHrmMapper.MapEntity,
            StdDrampHrmMapper.ToDto,
            StdDrampHrmMapper.MapEntity)
        { }
    }

    public class StdDrampFmService : StdRampService<
    StdDpfm, StdDpFmDto,
    StdDprampFm, StdDprampFmDto>
    {
        public override string AggregateName => "FmDescalerPlan";

        public StdDrampFmService() : base(
            StdDpFmMapper.ToDto,
            StdDpFmMapper.MapEntity,
            StdDrampFmMapper.ToDto,
            StdDrampFmMapper.MapEntity)
        { }
    }

    public class StdPcService : StdRampService<
    StdPc, StdPcDto,
    StdPcramp, StdPcRampDto>
    {
        public override string AggregateName => "FmPowerCoolingPlan";

        public StdPcService() : base(
            StdPcMapper.ToDto,
            StdPcMapper.MapEntity,
            StdPcRampMapper.ToDto,
            StdPcRampMapper.MapEntity)
        { }
    }

    public class StdRcpPassService : StdPassService<
    StdRcp, StdRcpDto,
    StdRcppass, StdRcpPassDto>
    {
        public override string AggregateName => "FmRollCoolPlan";

        public StdRcpPassService() : base(
            StdRcpMapper.ToDto,
            StdRcpMapper.MapEntity,
            StdRcpPassMapper.ToDto,
            StdRcpPassMapper.MapEntity)
        { }
    }

    public class StdIscpPassService : StdPassService<
    StdIscp, StdIscpDto,
    StdIscppass, StdIscpPassDto>
    {
        public override string AggregateName => "FmISCoolPlan";

        public StdIscpPassService() : base(
            StdIscpMapper.ToDto,
            StdIscpMapper.MapEntity,
            StdIscpPassMapper.ToDto,
            StdIscpPassMapper.MapEntity)
        { }
    }

    public class StdAopPassServices : StdPassService<
        StdAop, StdAopDto,
        StdAoppass, StdAopPassDto>
    {
        public override string AggregateName => "FmAntiOxPeelPlan";

        public StdAopPassServices() : base(
            StdAopMapper.ToDto,
            StdAopMapper.MapEntity,
            StdAopPassMapper.ToDto,
            StdAopPassMapper.MapEntity)
        { }
    }

    public class StdTpPassService : StdPassService<
        StdTp, StdTpDto,
        StdTppass, StdTpPassDto>
    {
        public override string AggregateName => "FmTensionPlan";

        public StdTpPassService() : base(
            StdTpMapper.ToDto,
            StdTpMapper.MapEntity,
            StdTpPassMapper.ToDto,
            StdTpPassMapper.MapEntity)
        { }
    }

    public class StdRglpPassService : StdPassService<
        StdRglp, StdRglpDto,
        StdRglppass, StdRglpPassDto>
    {
        public override string AggregateName => "FmRollGapLubPlan";

        public StdRglpPassService() : base(
            StdRglpMapper.ToDto,
            StdRglpMapper.MapEntity,
            StdRglpPassMapper.ToDto,
            StdRglpPassMapper.MapEntity)
        { }
    }

    public class StdDirFmPfcCycShiftService : StdPassService<
    StdDirFmPfcCycShiftP, StdDirFmPfcCycShiftDto,
    StdDirFmPfcCycShiftPpass, StdDirFmPfcCycShiftPassDto>
    {
        public override string AggregateName => "FmCyclicShiftPlan";

        public StdDirFmPfcCycShiftService() : base(
            StdDirFmPfcCycShiftPMapper.ToDto,
            StdDirFmPfcCycShiftPMapper.MapEntity,
            StdDirFmPfcCycShiftPassMapper.ToDto,
            StdDirFmPfcCycShiftPassMapper.MapEntity)
        { }
    }

    public class StdDirFmPfcParapPassService : StdPassService<
        StdDirFmPfcParaP, StdDirFmPfcParapDto,
        StdDirFmPfcParaPpass, StdDirFmPfcParapPassDto>
    {
        public override string AggregateName => "FmProfileFlatPlan";

        public StdDirFmPfcParapPassService() : base(
            StdDirFmPfcParapMapper.ToDto,
            StdDirFmPfcParapMapper.MapEntity,
            StdDirFmPfcParapPassMapper.ToDto,
            StdDirFmPfcParapPassMapper.MapEntity)
        { }
    }

    public class StdCompPlanService : StdService<
        StdCompPlan, StdCompPlanDto>
    {
        public override string AggregateName => "FmCompPlan";

        public StdCompPlanService() : base(
            StdCompPlanMapper.ToDto,
            StdCompPlanMapper.MapEntity)
        { }
    }
    public class StdIhpService : StdService<
        StdIhp, StdIhpDto>
    {
        public override string AggregateName => "FmIHPlan";

        public StdIhpService() : base(
            StdIhpMapper.ToDto,
            StdIhpMapper.MapEntity)
        { }
    }

    public class StdWmpPassService : StdPassService<
        StdWmp, StdWmpDto,
        StdWmppass, StdWmpPassDto>
    {
        public override string AggregateName => "FmWearModelPlan";

        public StdWmpPassService() : base(
            StdWmpMapper.ToDto,
            StdWmpMapper.MapEntity,
            StdWmpPassMapper.ToDto,
            StdWmpPassMapper.MapEntity)
        { }
    }

    public class StdSrpPassService : StdPassService<
        StdSrp, StdSrpDto,
        StdSrppass, StdSrpPassDto>
    {
        public override string AggregateName => "FmShiftModelPlan";

        public StdSrpPassService() : base(
            StdSrpMapper.ToDto,
            StdSrpMapper.MapEntity,
            StdSrpPassMapper.ToDto,
            StdSrpPassMapper.MapEntity)
        { }
    }

    public class StdCsStrategyService : StdService<StdCsStrategy, StdStrategyCsDto>
    {
        public override string AggregateName => "CsStrategySelection";

        public StdCsStrategyService() : base(
            StdStrategyCsMapper.ToDto,
            StdStrategyCsMapper.MapEntity)
        { }
    }

    public class StdCsProfileService : StdService<StdCsProfile, StdProfileCsDto>
    {
        public override string AggregateName => "CsProfileSelection";

        public StdCsProfileService() : base(
            StdProfileCsMapper.ToDto,
            StdProfileCsMapper.MapEntity)
        { }
    }

    public class StdCsRtCoolingService : StdService<StdCsRtCooling, StdRtCoolingCsDto>
    {
        public override string AggregateName => "CsRtcSelection";

        public StdCsRtCoolingService() : base(
            StdRtCoolingCsMapper.ToDto,
            StdRtCoolingCsMapper.MapEntity)
        { }
    }

    public class StdCscrService : StdService<StdCsCr, StdCrCsDto>
    {
        public override string AggregateName => "CsCrsSelection";

        public StdCscrService() : base(
            StdCrCsMapper.ToDto,
            StdCrCsMapper.MapEntity)
        { }
    }

    public class StdCsCoilTempOffsetService : StdService<StdCsCoilTempOffset, StdCsCoilTempOffsetDto>
    {
        public override string AggregateName => "CsCoilTempOffsetSelection";

        public StdCsCoilTempOffsetService() : base(
            StdCsCoilTempOffsetMapper.ToDto,
            StdCsCoilTempOffsetMapper.MapEntity)
        { }
    }

    public class StdCsPerfService : StdService<StdCsPerf, StdCsPerfDto>
    {
        public override string AggregateName => "CsPerfSelection";

        public StdCsPerfService() : base(
            StdCsPerfMapper.ToDto,
            StdCsPerfMapper.MapEntity)
        { }
    }

    public class StdcsedgemaskingService : StdService<StdCsEdgeMasking, StdcsedgemaskingDto>
    {
        public override string AggregateName => "CsEdgeMaskingSelection";

        public StdcsedgemaskingService() : base(
            StdcsedgemaskingMapper.ToDto,
            StdcsedgemaskingMapper.MapEntity)
        { }
    }

}
