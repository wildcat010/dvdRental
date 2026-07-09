using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class Csprottick
{
    public int Meid { get; set; }

    public int Seg { get; set; }

    public short? OccCs { get; set; }

    public short? OccFm { get; set; }

    public short? OccTbc { get; set; }

    public int? Botvsetpcnt { get; set; }

    public int? Botvstatescnt { get; set; }

    public double? CoefInd0 { get; set; }

    public double? CoefInd1 { get; set; }

    public double? CoefInd2 { get; set; }

    public double? Coiltempsp { get; set; }

    public double? DctempoffsetInd0 { get; set; }

    public double? DctempoffsetInd1 { get; set; }

    public double? DctempoffsetInd2 { get; set; }

    public double? DctempoffsetInd3 { get; set; }

    public int? Fmvsetpcnt { get; set; }

    public int? Fmvstatescnt { get; set; }

    public double? Performatoroffset { get; set; }

    public double? Ril { get; set; }

    public double? Slope { get; set; }

    public double? Speed { get; set; }

    public double? Speed5diagdiff { get; set; }

    public double? Tdiff { get; set; }

    public double? Tempcs { get; set; }

    public double? Tempcsdiff { get; set; }

    public double? Tempfm { get; set; }

    public double? Temprm { get; set; }

    public double? Temptbc { get; set; }

    public double? Temperaturedeviation { get; set; }

    public double? Thickness { get; set; }

    public int? Topvsetpcnt { get; set; }

    public int? Topvstatescnt { get; set; }

    public double? Totalcalcwaterflow { get; set; }

    public string Valvesetpbot { get; set; }

    public string Valvesetpfm { get; set; }

    public string Valvesetptop { get; set; }

    public string Valvestatebot { get; set; }

    public string Valvestatefm { get; set; }

    public string Valvestatetop { get; set; }

    public string Mop { get; set; }

    public DateTime? Toc { get; set; }

    public DateTime? Tom { get; set; }
}
