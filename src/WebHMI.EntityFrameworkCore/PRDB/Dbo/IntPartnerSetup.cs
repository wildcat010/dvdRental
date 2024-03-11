using System;
using System.Collections.Generic;

namespace WebHMI.PRDB.Dbo;

public partial class IntPartnerSetup
{
    /// <summary>
    /// short name of communication partner (= aggregate name)
    /// </summary>
    public string PartnerId { get; set; }

    /// <summary>
    /// name to be used, e.g. entry from TNS name, ODBC data source name
    /// </summary>
    public string ConnectName { get; set; }

    /// <summary>
    /// type of database. allowed values: Oracle, Access, Mssql
    /// </summary>
    public string DbType { get; set; }

    /// <summary>
    /// description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// driver to be used. allowed values: oODBC, oDznSQLOracle
    /// </summary>
    public string Driver { get; set; }

    /// <summary>
    /// computer name
    /// </summary>
    public string NodeName { get; set; }

    /// <summary>
    /// password (stored as plain text)
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// port number used by DB
    /// </summary>
    public short? Port { get; set; }

    /// <summary>
    /// schema name
    /// </summary>
    public string Schema2 { get; set; }

    /// <summary>
    /// 1=communication with this partner is performed, 0=no communication with this partner
    /// </summary>
    public short Used { get; set; }

    /// <summary>
    /// user that shall be used to connect to DB
    /// </summary>
    public string UserName2 { get; set; }

    /// <summary>
    /// modifying process
    /// </summary>
    public string Mop { get; set; }

    /// <summary>
    /// time of creation
    /// </summary>
    public DateTime? Toc { get; set; }

    /// <summary>
    /// time of modification
    /// </summary>
    public DateTime? Tom { get; set; }
}
