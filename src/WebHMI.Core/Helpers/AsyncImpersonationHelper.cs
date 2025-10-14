using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading.Tasks;

namespace WebHMI.Helpers
{
    public class ImpersonationHelper
    {
        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool LogonUser(string username, string domain, string password,
            int logonType, int logonProvider, out IntPtr token);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr handle);

        public static void Run(string domain, string username, string password, Action action)
        {
            const int LOGON32_LOGON_NEW_CREDENTIALS = 9;
            const int LOGON32_PROVIDER_WINNT50 = 3;

            if (!LogonUser(username, domain, password,
                LOGON32_LOGON_NEW_CREDENTIALS, LOGON32_PROVIDER_WINNT50, out IntPtr token))
            {
                int errorCode = Marshal.GetLastWin32Error();
                throw new System.ComponentModel.Win32Exception(errorCode, "LogonUser failed");
            }

            try
            {
                var identity = new WindowsIdentity(token);
                WindowsIdentity.RunImpersonated(identity.AccessToken, action);
            }
            finally
            {
                CloseHandle(token);
            }
        }
    }
}
