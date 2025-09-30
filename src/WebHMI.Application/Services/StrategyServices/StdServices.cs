using WebHMI.Dtos;
using WebHMI.Dtos.Strategies;
using WebHMI.Dtos.Strategy.StdDtos.StdSingleDtos;
using WebHMI.Mapping.Extensions;
using WebHMI.Mapping.Extensions.Strategy;
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

    // ??
    public class StdDpFmService : StdService<
    StdDpfm, StdDpFmDto>
    {
        public override string AggregateName => "FmDescalerPlan";

        public StdDpFmService() : base(
            StdDpFmMapper.ToDto,
            StdDpFmMapper.MapEntity)
        { }
    }

    public class StdDrampFmService : StdService<
   StdDprampFm, StdDprampFmDto>
    {
        public override string AggregateName => "RmDescalerPlan";

        public StdDrampFmService() : base(
            StdDrampFmMapper.ToDto,
            StdDrampFmMapper.MapEntity)
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
}
