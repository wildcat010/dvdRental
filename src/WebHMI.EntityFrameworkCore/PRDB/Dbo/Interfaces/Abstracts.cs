using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebHMI.API.Prdb.Abstract;

namespace WebHMI.PRDB.Dbo
{
    public partial class Aoppass : IMaterialIdTypeOrder { }

    public partial class CsCr : IMaterialIdTypeOrder { }

    public partial class EdOrdEnt : IMaterialIdTypeOrder { }

    public partial class EdLogEnt : IMaterialIdTypeLogical { }
    public partial class EdPhyEnt : IMaterialIdTypePhysical { }
    public partial class CsPerf : IMaterialIdTypeOrder { }
    public partial class CsProfile : IMaterialIdTypeOrder { }
    public partial class CsRtCooling : IMaterialIdTypeOrder { }
    public partial class CsStrategy : IMaterialIdTypeOrder { }
    public partial class DirFmPfcCycShiftP : IMaterialIdTypeOrder { }
    public partial class DirFmPfcCycShiftPpass : IMaterialIdTypeOrder { }
    public partial class DirFmPfcParaP : IMaterialIdTypeOrder { }
    public partial class DirFmPfcParaPpass : IMaterialIdTypeOrder { }
    public partial class Dpfm : IMaterialIdTypeOrder { }
    public partial class Dphrm : IMaterialIdTypeOrder { }
    public partial class Ihp : IMaterialIdTypeOrder { }
    public partial class Iscp : IMaterialIdTypeOrder { }
    public partial class Iscppass : IMaterialIdTypeOrder { }
    public partial class Lp : IMaterialIdTypeOrder { }
    public partial class Lppass : IMaterialIdTypeOrder { }
    public partial class Rcp : IMaterialIdTypeOrder { }
    public partial class Rcppass : IMaterialIdTypeOrder { }
    public partial class Rglp : IMaterialIdTypeOrder { }
    public partial class SpOrd2Pc : IMaterialIdTypeOrder { }
    public partial class Srp : IMaterialIdTypeOrder { }
    public partial class Tp : IMaterialIdTypeOrder { }
    public partial class Tppass : IMaterialIdTypeOrder { }
    public partial class Pc : IMaterialIdTypeOrder { }
    public partial class Pcramp : IMaterialIdTypeOrder { }
}
