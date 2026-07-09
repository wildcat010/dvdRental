using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Me1
{
    public string Mecreator { get; set; }

    public int Meid { get; set; }

    public short Mesid { get; set; }

    public string Compmecreator { get; set; }

    public int? Compmeid { get; set; }

    public short? Compmesid { get; set; }

    public short? Comppos { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }

    public virtual ICollection<Adord2pc> Adord2pcs { get; set; } = new List<Adord2pc>();

    public virtual ICollection<Adord2pcstand> Adord2pcstands { get; set; } = new List<Adord2pcstand>();

    public virtual ICollection<Aoppass> Aoppasses { get; set; } = new List<Aoppass>();

    public virtual ICollection<Cscr> Cscrs { get; set; } = new List<Cscr>();

    public virtual ICollection<Csedgemasking> Csedgemaskings { get; set; } = new List<Csedgemasking>();

    public virtual ICollection<Cspccurve> Cspccurves { get; set; } = new List<Cspccurve>();

    public virtual Cspcresult Cspcresult { get; set; }

    public virtual ICollection<Cspcspeeddiag> Cspcspeeddiags { get; set; } = new List<Cspcspeeddiag>();

    public virtual ICollection<Csperf> Csperves { get; set; } = new List<Csperf>();

    public virtual ICollection<Csprofile> Csprofiles { get; set; } = new List<Csprofile>();

    public virtual ICollection<Csrtcooling> Csrtcoolings { get; set; } = new List<Csrtcooling>();

    public virtual ICollection<Csstrategy> Csstrategies { get; set; } = new List<Csstrategy>();

    public virtual ICollection<Defect> Defects { get; set; } = new List<Defect>();

    public virtual ICollection<Dirfmpfccycshiftppass> Dirfmpfccycshiftppasses { get; set; } = new List<Dirfmpfccycshiftppass>();

    public virtual ICollection<Dirfmpfccycshiftp> Dirfmpfccycshiftps { get; set; } = new List<Dirfmpfccycshiftp>();

    public virtual ICollection<Dirfmpfcparappass> Dirfmpfcparappasses { get; set; } = new List<Dirfmpfcparappass>();

    public virtual ICollection<Dirfmpfcparap> Dirfmpfcparaps { get; set; } = new List<Dirfmpfcparap>();

    public virtual ICollection<Dpfm> Dpfms { get; set; } = new List<Dpfm>();

    public virtual ICollection<Dphrm> Dphrms { get; set; } = new List<Dphrm>();

    public virtual ICollection<Dprampfm> Dprampfms { get; set; } = new List<Dprampfm>();

    public virtual ICollection<Dpramphrm> Dpramphrms { get; set; } = new List<Dpramphrm>();

    public virtual ICollection<Edlogent> Edlogents { get; set; } = new List<Edlogent>();

    public virtual ICollection<Edordent> Edordents { get; set; } = new List<Edordent>();

    public virtual ICollection<Edphyent> Edphyents { get; set; } = new List<Edphyent>();

    public virtual ICollection<Ihp> Ihps { get; set; } = new List<Ihp>();

    public virtual ICollection<Iscppass> Iscppasses { get; set; } = new List<Iscppass>();

    public virtual ICollection<Iscp> Iscps { get; set; } = new List<Iscp>();

    public virtual ICollection<Lppass> Lppasses { get; set; } = new List<Lppass>();

    public virtual ICollection<Lp> Lps { get; set; } = new List<Lp>();

    public virtual Me Me { get; set; }

    public virtual Me MeNavigation { get; set; }

    public virtual ICollection<Rcppass> Rcppasses { get; set; } = new List<Rcppass>();

    public virtual ICollection<Rcp> Rcps { get; set; } = new List<Rcp>();

    public virtual ICollection<Rglppass> Rglppasses { get; set; } = new List<Rglppass>();

    public virtual ICollection<Rglp> Rglps { get; set; } = new List<Rglp>();

    public virtual ICollection<Spord2pc> Spord2pcs { get; set; } = new List<Spord2pc>();

    public virtual ICollection<Spord2pcstand> Spord2pcstands { get; set; } = new List<Spord2pcstand>();

    public virtual ICollection<Srppass> Srppasses { get; set; } = new List<Srppass>();

    public virtual ICollection<Srp> Srps { get; set; } = new List<Srp>();

    public virtual ICollection<StatAdord1pc> StatAdord1pcs { get; set; } = new List<StatAdord1pc>();

    public virtual ICollection<StatAdord2pc> StatAdord2pcs { get; set; } = new List<StatAdord2pc>();

    public virtual ICollection<StatAdord2pcstand> StatAdord2pcstands { get; set; } = new List<StatAdord2pcstand>();

    public virtual ICollection<StatAdordent> StatAdordents { get; set; } = new List<StatAdordent>();

    public virtual ICollection<StatCscoiltempoffset> StatCscoiltempoffsets { get; set; } = new List<StatCscoiltempoffset>();

    public virtual ICollection<StatCscr> StatCscrs { get; set; } = new List<StatCscr>();

    public virtual ICollection<StatCsedgemasking> StatCsedgemaskings { get; set; } = new List<StatCsedgemasking>();

    public virtual ICollection<StatCsperf> StatCsperves { get; set; } = new List<StatCsperf>();

    public virtual ICollection<StatCsprofile> StatCsprofiles { get; set; } = new List<StatCsprofile>();

    public virtual ICollection<StatCsrtcooling> StatCsrtcoolings { get; set; } = new List<StatCsrtcooling>();

    public virtual ICollection<StatCsstrategy> StatCsstrategies { get; set; } = new List<StatCsstrategy>();

    public virtual ICollection<StatDirfmpfccycshiftppass> StatDirfmpfccycshiftppasses { get; set; } = new List<StatDirfmpfccycshiftppass>();

    public virtual ICollection<StatDirfmpfccycshiftp> StatDirfmpfccycshiftps { get; set; } = new List<StatDirfmpfccycshiftp>();

    public virtual ICollection<StatDirfmpfcparappass> StatDirfmpfcparappasses { get; set; } = new List<StatDirfmpfcparappass>();

    public virtual ICollection<StatDirfmpfcparap> StatDirfmpfcparaps { get; set; } = new List<StatDirfmpfcparap>();

    public virtual ICollection<StatEdlogent> StatEdlogents { get; set; } = new List<StatEdlogent>();

    public virtual ICollection<StatEdordent> StatEdordents { get; set; } = new List<StatEdordent>();

    public virtual ICollection<StatEdphyent> StatEdphyents { get; set; } = new List<StatEdphyent>();

    public virtual ICollection<StatLppass> StatLppasses { get; set; } = new List<StatLppass>();

    public virtual ICollection<StatMsmdir> StatMsmdirs { get; set; } = new List<StatMsmdir>();

    public virtual ICollection<StatSplogent> StatSplogents { get; set; } = new List<StatSplogent>();

    public virtual ICollection<StatSpord1pcstand> StatSpord1pcstands { get; set; } = new List<StatSpord1pcstand>();

    public virtual ICollection<StatSpord2pc> StatSpord2pcs { get; set; } = new List<StatSpord2pc>();

    public virtual ICollection<StatSpord2pcstand> StatSpord2pcstands { get; set; } = new List<StatSpord2pcstand>();

    public virtual ICollection<StatSpordent> StatSpordents { get; set; } = new List<StatSpordent>();

    public virtual ICollection<StatSpphyent> StatSpphyents { get; set; } = new List<StatSpphyent>();

    public virtual ICollection<Tppass> Tppasses { get; set; } = new List<Tppass>();

    public virtual ICollection<Tp> Tps { get; set; } = new List<Tp>();

    public virtual ICollection<Wmppass> Wmppasses { get; set; } = new List<Wmppass>();
}
