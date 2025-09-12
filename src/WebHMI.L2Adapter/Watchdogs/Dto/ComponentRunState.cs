namespace WebHMI.L2Adapter.Watchdogs.Dto
{
    /// <summary>
    /// WebHMI equivalent of an <see cref="XIDL.ComponentRunState"/>
    /// </summary>
    public enum ComponentRunState
    {
        IDLE = XIDL.ComponentRunState.IDLE,
        BUSY = XIDL.ComponentRunState.BUSY,
        PAUSED = XIDL.ComponentRunState.PAUSED,
        STOPPED = XIDL.ComponentRunState.STOPPED,
        CRASHED = XIDL.ComponentRunState.CRASHED,
        CREATING = XIDL.ComponentRunState.CREATING,
        BLOCKED = XIDL.ComponentRunState.BLOCKED,
        KILLED = XIDL.ComponentRunState.KILLED,
        HALTED = XIDL.ComponentRunState.HALTED,
        NON_EXISTENT = XIDL.ComponentRunState.NON_EXISTENT
    }
}
