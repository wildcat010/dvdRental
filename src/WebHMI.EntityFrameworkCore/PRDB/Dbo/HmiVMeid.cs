using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class HmiVMeid
{
    public int PhyId { get; set; }

    public string PhyName { get; set; }

    public string PhyCreator { get; set; }

    public int LogId { get; set; }

    public string LogName { get; set; }

    public string LogCreator { get; set; }

    public int OrdId1 { get; set; }

    public string OrdName1 { get; set; }

    public string OrdCreator1 { get; set; }

    public int? OrdId2 { get; set; }

    public string OrdName2 { get; set; }

    public string OrdCreator2 { get; set; }

    public int? OrdId3 { get; set; }

    public string OrdName3 { get; set; }

    public string OrdCreator3 { get; set; }
}
