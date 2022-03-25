using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using static Utilities.Classes.NativeMembers;

namespace Utilities.Classes
{
    internal class NativeMethods
    {
        #region Get Process Owner
        /// <summary>
        /// Registers resources to a Restart Manager session.
        /// The Restart Manager uses the list of resources registered with the session to determine which applications
        /// and services must be shut down and restarted. Resources can be identified by filenames, service short names,
        /// or RM_UNIQUE_PROCESS structures that describe running applications.
        /// The RmRegisterResources function can be used by a primary or secondary installer.
        /// </summary>
        /// <param name="dwSessionHandle">A handle to an existing Restart Manager session.</param>
        /// <param name="nFiles">The number of files being registered.</param>
        /// <param name="rgsFilenames">An array of null-terminated strings of full filename paths. This parameter can be NULL if nFiles is 0.</param>
        /// <param name="nApplications">The number of processes being registered.</param>
        /// <param name="rgApplications">An array of RM_UNIQUE_PROCESS structures. This parameter can be NULL if nApplications is 0.</param>
        /// <param name="nServices">The number of services to be registered.</param>
        /// <param name="rgsServiceNames">An array of null-terminated strings of service short names. This parameter can be NULL if nServices is 0.</param>
        /// <returns>This is the most recent error received. The function can return one of the system error codes that are defined in Winerror.h.</returns>
        [DllImport("rstrtmgr.dll", CharSet = CharSet.Unicode)]
        private static extern RmResult RmRegisterResources(
            int dwSessionHandle,
            uint nFiles,
            string[] rgsFilenames,
            uint nApplications,
            [In] RM_UNIQUE_PROCESS[] rgApplications,
            uint nServices,
            string[] rgsServiceNames);

        /// <summary>
        /// Starts a new Restart Manager session.
        /// A maximum of 64 Restart Manager sessions per user session can be open on the system at the same time.
        /// When this function starts a session, it returns a session handle and session key that can be used in subsequent calls to the Restart Manager API.
        /// </summary>
        /// <param name="pSessionHandle">
        /// A pointer to the handle of a Restart Manager session.
        /// The session handle can be passed in subsequent calls to the Restart Manager API.
        /// </param>
        /// <param name="dwSessionFlags">Reserved. This parameter should be 0.</param>
        /// <param name="strSessionKey">
        /// A null-terminated string that contains the session key to the new session.
        /// The string must be allocated before calling the RmStartSession function.
        /// </param>
        /// <returns>This is the most recent error received. The function can return one of the system error codes that are defined in Winerror.h.</returns>
        [DllImport("rstrtmgr.dll", CharSet = CharSet.Auto)]
        private static extern RmResult RmStartSession(out int pSessionHandle, int dwSessionFlags, string strSessionKey);

        /// <summary>
        /// Ends the Restart Manager session.
        /// This function should be called by the primary installer that has previously started the session by calling the RmStartSession function.
        /// The RmEndSession function can be called by a secondary installer that is joined to the session once no more resources need to be registered
        /// by the secondary installer. 
        /// </summary>
        /// <param name="dwSessionHandle">A handle to an existing Restart Manager session.</param>
        /// <returns>This is the most recent error received. The function can return one of the system error codes that are defined in Winerror.h.</returns>
        [DllImport("rstrtmgr.dll")]
        private static extern RmResult RmEndSession(int dwSessionHandle);

        /// <summary>
        /// Gets a list of all applications and services that are currently using resources that have been registered with the Restart Manager session.
        /// </summary>
        /// <param name="dwSessionHandle">A handle to an existing Restart Manager session.</param>
        /// <param name="pnProcInfoNeeded">
        /// A pointer to an array size necessary to receive RM_PROCESS_INFO structures required to return information for all affected applications and services.
        /// </param>
        /// <param name="pnProcInfo">A pointer to the total number of RM_PROCESS_INFO structures in an array and number of structures filled.</param>
        /// <param name="rgAffectedApps">
        /// An array of RM_PROCESS_INFO structures that list the applications and services using resources that have been registered with the session.
        /// </param>
        /// <param name="lpdwRebootReasons">
        /// Pointer to location that receives a value of the RM_REBOOT_REASON enumeration that describes the reason a system restart is needed.
        /// </param>
        /// <returns>This is the most recent error received. The function can return one of the system error codes that are defined in Winerror.h.</returns>
        [DllImport("rstrtmgr.dll")]
        private static extern RmResult RmGetList(
            int dwSessionHandle,
            out uint pnProcInfoNeeded,
            ref uint pnProcInfo,
            [In, Out] RM_PROCESS_INFO[] rgAffectedApps,
            out RM_REBOOT_REASON lpdwRebootReasons);

        [DllImport("advapi32.dll", SetLastError = true)]
        private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr hObject);
        #endregion

        #region List User Status
        [DllImport("wtsapi32.dll")]
        static extern IntPtr WTSOpenServer([MarshalAs(UnmanagedType.LPStr)] string pServerName);

        [DllImport("wtsapi32.dll")]
        static extern void WTSCloseServer(IntPtr hServer);

        [DllImport("wtsapi32.dll")]
        static extern Int32 WTSEnumerateSessions(
            IntPtr hServer,
            [MarshalAs(UnmanagedType.U4)] Int32 Reserved,
            [MarshalAs(UnmanagedType.U4)] Int32 Version,
            ref IntPtr ppSessionInfo,
            [MarshalAs(UnmanagedType.U4)] ref Int32 pCount);

        [DllImport("wtsapi32.dll")]
        static extern void WTSFreeMemory(IntPtr pMemory);

        [DllImport("wtsapi32.dll")]
        static extern bool WTSQuerySessionInformation(
            IntPtr hServer, int sessionId, WTS_INFO_CLASS wtsInfoClass, out IntPtr ppBuffer, out uint pBytesReturned);
        #endregion


        #region Public Methods
        public static bool IsAdministrator() {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
        }
        public static RM_PROCESS_INFO[] FindLockedFileProcesses(string path) {
            int handle;
            if (RmStartSession(out handle, 0, strSessionKey: Guid.NewGuid().ToString()) != RmResult.ERROR_SUCCESS)
                throw new Exception("Could not begin session. Unable to determine file lockers.");

            try {
                string[] resources = { path }; // Just checking on one resource.

                if (RmRegisterResources(handle, (uint)resources.LongLength, resources, 0, null, 0, null) != RmResult.ERROR_SUCCESS)
                    throw new Exception("Could not register resource.");

                // The first try is done expecting at most ten processes to lock the file.
                uint arraySize = 10;
                RmResult result;
                do {
                    var array = new RM_PROCESS_INFO[arraySize];
                    uint arrayCount;
                    RM_REBOOT_REASON lpdwRebootReasons;
                    result = RmGetList(handle, out arrayCount, ref arraySize, array, out lpdwRebootReasons);
                    if (result == RmResult.ERROR_SUCCESS) {
                        // Adjust the array length to fit the actual count.

                        Array.Resize(ref array, (int)arrayCount);
                        return array;
                    } else if (result == RmResult.ERROR_MORE_DATA) {
                        // We need to initialize a bigger array. We only set the size, and do another iteration.
                        // (the out parameter arrayCount contains the expected value for the next try)
                        arraySize = arrayCount;
                    } else {
                        throw new Exception("Could not list processes locking resource. Failed to get size of result.");
                    }
                } while (result != RmResult.ERROR_SUCCESS);
            } finally {
                RmEndSession(handle);
            }
            return new RM_PROCESS_INFO[0];
        }
        public static string GetProcessUser(Process process) {

            IntPtr processHandle = IntPtr.Zero;
            try {
                OpenProcessToken(process.Handle, 8, out processHandle);
                WindowsIdentity wi = new WindowsIdentity(processHandle);
                string user = wi.Name;
                return user.Contains(@"\") ? user.Substring(user.IndexOf(@"\") + 1) : user;
            } catch {
                return "";
            } finally {
                if (processHandle != IntPtr.Zero) {
                    CloseHandle(processHandle);
                }
            }
        }
        public static List<User> ListUsersWithStatus() {
            IntPtr serverHandle = IntPtr.Zero;
            List<User> resultList = new List<User>();
            serverHandle = WTSOpenServer(Environment.MachineName);

            try {
                IntPtr sessionInfoPtr = IntPtr.Zero;
                IntPtr userPtr = IntPtr.Zero;
                IntPtr connectStatePtr = IntPtr.Zero;
                Int32 sessionCount = 0;
                Int32 retVal = WTSEnumerateSessions(serverHandle, 0, 1, ref sessionInfoPtr, ref sessionCount);
                Int32 dataSize = Marshal.SizeOf(typeof(WTS_SESSION_INFO));
                IntPtr currentSession = sessionInfoPtr;
                uint bytes = 0;
                string userConnectionStatus = "";

                if (retVal != 0) {
                    for (int i = 0; i < sessionCount; i++) {
                        WTS_SESSION_INFO si = (WTS_SESSION_INFO)Marshal.PtrToStructure((System.IntPtr)currentSession, typeof(WTS_SESSION_INFO));
                        currentSession += dataSize;

                        WTSQuerySessionInformation(serverHandle, si.SessionID, WTS_INFO_CLASS.WTSUserName, out userPtr, out bytes);
                        WTSQuerySessionInformation(serverHandle, si.SessionID, WTS_INFO_CLASS.WTSConnectState, out connectStatePtr, out bytes);

                        userConnectionStatus = Marshal.ReadInt32(connectStatePtr) switch {
                            0 => "Active",
                            1 => "Connected",
                            2 => "Connect Query",
                            3 => "Shadow",
                            4 => "Disconnected",
                            5 => "Idle",
                            6 => "Listen",
                            7 => "Reset",
                            8 => "Down",
                            9 => "Init",
                            _ => "Unknown",
                        };
                        if (Marshal.PtrToStringAnsi(userPtr) != null && !Marshal.PtrToStringAnsi(userPtr).Equals("")) {
                            resultList.Add(new User(Marshal.PtrToStringAnsi(userPtr),userConnectionStatus));
                        }
                        Console.WriteLine(userConnectionStatus);
                        WTSFreeMemory(userPtr);
                        WTSFreeMemory(connectStatePtr);
                    }

                    WTSFreeMemory(sessionInfoPtr);
                }
            } finally {
                WTSCloseServer(serverHandle);
            }
            return resultList;

        }
        #endregion
    }
}
