using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVMeids2
{
    public int PhyId { get; set; }

    public short PhyBasId { get; set; }

    public string PhyName { get; set; }

    public string PhyCreator { get; set; }

    public short? PhyStatus { get; set; }

    public short Mesid { get; set; }

    public int LogId { get; set; }

    public short LogBasId { get; set; }

    public string LogName { get; set; }

    public string LogCreator { get; set; }

    public short? LogStatus { get; set; }

    public short? LogPos { get; set; }

    public int OrdId { get; set; }

    public short OrdBasId { get; set; }

    public string OrdName { get; set; }

    public string OrdCreator { get; set; }

    public short? OrdStatus { get; set; }

    public short? OrdPos { get; set; }

    public int? OutLogId { get; set; }

    public short? OutLogBasId { get; set; }

    public string OutLogName { get; set; }

    public string OutLogCreator { get; set; }

    public short? OutLogStatus { get; set; }

    public int? OutPhyId { get; set; }

    public short? OutPhyBasId { get; set; }

    public string OutPhyName { get; set; }

    public string OutPhyCreator { get; set; }

    public short? OutPhyStatus { get; set; }
}
