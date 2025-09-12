namespace WebHMI.L2Adapter.Watchdogs.Dto
{
    /// <summary>
    /// WebHMI equivalent of an <see cref="XIDL.ERestartPending"/>
    /// </summary>
    public enum RestartPending
    {
        No = XIDL.ERestartPending.no,
        Yes = XIDL.ERestartPending.yes,
        Undecided = XIDL.ERestartPending.undecided,
        Error = XIDL.ERestartPending.error
    }
}
