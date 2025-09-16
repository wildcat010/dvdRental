namespace WebHMI.L2Adapter.Watchdogs.Dto
{
    /// <summary>
    /// WebHMI equivalent of an <see cref="XIDL.ComponentHealthState"/>
    /// </summary>
    public enum ComponentHealthState
    {
        GREEN = XIDL.ComponentHealthState.GREEN,
        YELLOW = XIDL.ComponentHealthState.YELLOW,
        RED = XIDL.ComponentHealthState.RED,
        UNKNOWN = 99,
    }
}
