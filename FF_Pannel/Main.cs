using Beyondmem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace FF_Pannel
{
    public partial class Main : Form
    {
        private System.Timers.Timer Proctimer;
        public Main()
        {
            InitializeComponent();
            GetProcID(1);
            Proctimer = new System.Timers.Timer();
            Proctimer.Interval = 15000;
            Proctimer.Elapsed += findproc;
            Proctimer.AutoReset = true;
            timer1.Start();

        }
        [DllImport("user32.dll")]
        public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);
        [DllImport("KERNEL32.DLL")]
        public static extern IntPtr CreateToolhelp32Snapshot(uint flags, uint processid);
        [DllImport("KERNEL32.DLL")]
        public static extern int Process32First(IntPtr handle, ref ProcessEntry32 pe);
        [DllImport("KERNEL32.DLL")]
        public static extern int Process32Next(IntPtr handle, ref ProcessEntry32 pe);
        private static string info;
        #region Change Mem
        public static async Task ChangeMem(string original, string replace, string mode)
        {
            info = "0";
            if (PID == null || Convert.ToInt32(PID) == 0)
            {
                info = "1";
                return;
            }

            IEnumerable<long> scanmem;
            try
            {
                MemLib.OpenProcess(Convert.ToInt32(PID));
                scanmem = await MemLib.AoBScan(0L, 140737488355327L, original, true, true);
            }
            catch
            {
                info = "4";
                return;
            }

            if (scanmem.Count() == 0)
            {
                info = "3";
                return;
            }

            Parallel.ForEach(scanmem, num =>
            {
                MemLib.OpenProcess(Convert.ToInt32(PID));
                MemLib.ChangeProtection(num.ToString("X"), MemMirza.MemoryProtection.ReadWrite, out MemMirza.MemoryProtection _);
                MemLib.WriteMemory(num.ToString("X"), "bytes", replace);
            });

            if (mode == "1")
            {
                info = "2";
            }
            else if (mode == "0")
            {
                info = "-2";
            }
        }
        #endregion
        public static MemMirza MemLib = new MemMirza();
        private async void findproc(Object source, System.Timers.ElapsedEventArgs e)

        {
            if (Convert.ToInt32(PID) == 0)
            {
                hook.Text = "Hook : PID - False {" + PID + "}";
                GetProcID(1);
            }
            else
            {
                hook.Text = "Hook : PID - True {" + PID + "}";
            }
            GetProcID(1);
        }

        public static string PID;
        public static string GetProcID(int index)
        {
            string result = "";
            checked
            {
                if (index == 1 || index == 0)
                {
                    IntPtr intPtr = IntPtr.Zero;
                    uint num = 0U;
                    IntPtr intPtr2 = CreateToolhelp32Snapshot(2U, 0U);
                    if ((int)intPtr2 > 0)
                    {
                        ProcessEntry32 processEntry = default(ProcessEntry32);
                        processEntry.dwSize = (uint)Marshal.SizeOf<ProcessEntry32>(processEntry);
                        for (int num2 = Process32First(intPtr2, ref processEntry); num2 == 1; num2 = Process32Next(intPtr2, ref processEntry))
                        {
                            IntPtr intPtr3 = Marshal.AllocHGlobal((int)processEntry.dwSize);
                            Marshal.StructureToPtr<ProcessEntry32>(processEntry, intPtr3, true);
                            object obj = Marshal.PtrToStructure(intPtr3, typeof(ProcessEntry32));
                            ProcessEntry32 processEntry2 = (obj != null) ? ((ProcessEntry32)obj) : default(ProcessEntry32);
                            Marshal.FreeHGlobal(intPtr3);

                            if (processEntry2.szExeFile.Contains("HD-Player") && processEntry2.cntThreads > num)
                            {
                                num = processEntry2.cntThreads;
                                intPtr = (IntPtr)((long)(unchecked((ulong)processEntry2.th32ProcessID)));
                            }
                            if (processEntry2.szExeFile.Contains("HD-Player.exe") && processEntry2.cntThreads > num)
                            {
                                num = processEntry2.cntThreads;
                                intPtr = (IntPtr)((long)(unchecked((ulong)processEntry2.th32ProcessID)));
                            }
                            if (processEntry2.szExeFile.Contains("AndroidProcess") && processEntry2.cntThreads > num)
                            {
                                num = processEntry2.cntThreads;
                                intPtr = (IntPtr)((long)(unchecked((ulong)processEntry2.th32ProcessID)));
                            }

                            if (processEntry2.szExeFile.Contains("LdVBoxHeadless") && processEntry2.cntThreads > num)
                            {
                                num = processEntry2.cntThreads;
                                intPtr = (IntPtr)((long)(unchecked((ulong)processEntry2.th32ProcessID)));
                            }

                            if (processEntry2.szExeFile.Contains("MEmuHeadless") && processEntry2.cntThreads > num)
                            {
                                num = processEntry2.cntThreads;
                                intPtr = (IntPtr)((long)(unchecked((ulong)processEntry2.th32ProcessID)));
                            }

                            if (processEntry2.szExeFile.Contains("NoxVMHandle") && processEntry2.cntThreads > num)
                            {
                                num = processEntry2.cntThreads;
                                intPtr = (IntPtr)((long)(unchecked((ulong)processEntry2.th32ProcessID)));
                            }

                            if (processEntry2.szExeFile.Contains("aow_exe") && processEntry2.cntThreads > num)
                            {
                                num = processEntry2.cntThreads;
                                intPtr = (IntPtr)((long)(unchecked((ulong)processEntry2.th32ProcessID)));
                            }
                        }
                    }
                    result = Convert.ToString(intPtr);
                    PID = Convert.ToString(intPtr);
                }
                return result;
            }
        }
        public struct ProcessEntry32
        {
            public uint dwSize;
            public uint cntUsage;
            public uint th32ProcessID;
            public IntPtr th32DefaultHealabel1;
            public uint th32ModuleID;
            public uint cntThreads;
            public uint th32ParentProcessID;
            public int pcPriClassBase;
            public uint dwFlags;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szExeFile;
        }



        private void Main_Load(object sender, EventArgs e)
        {
            Proctimer.Enabled = true;
            Key.Text = "Username: " + Form1.KeyAuthApp.user_data.username;
            Expiry.Text = "Expiry: " + UnixTimeToDateTime(long.Parse(Form1.KeyAuthApp.user_data.subscriptions[0].expiry));
            IP.Text ="IP: " +Form1.KeyAuthApp.user_data.ip;
           


        }
        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            try
            {
                dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            }
            catch
            {
                dtDateTime = DateTime.MaxValue;
            }
            return dtDateTime;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (info == "0")
            {
                status.ForeColor = Color.YellowGreen;
                status.Text = "Wait For Apply";
            }
            else if (info == "1")
            {
                status.ForeColor = Color.Red;
                status.Text = "No Emulator Found";
            }
            else if (info == "-2")
            {
                status.Text = "YOUR HACK DEACTIVE!";
            }
            else if (info == "2")
            {
                status.Text = "YOUR HACK ACTIVE!";
            }
            else if (info == "3")
            {
                status.Text = "Maybe Already Applied Or Nothing Found";
            }
            else if (info == "4")
            {
                status.Text = "Wrong PID Please Refresh";
            }


        }

        private async void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            Int32 proc = Process.GetProcessesByName("HD-Player")[0].Id;
            MemLib.OpenProcess(proc);

            MemLib.OpenProcess(Convert.ToInt32(PID));
            IEnumerable<long> longs = await MemLib.AoBScan2(("00 00 00 00 00 00 A5 43 00 00 00 00 ?? ?? ?? ?? 00 00 00 00 00 00 00 00 ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 ?? ?? ?? ?? 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 80 BF"), true);

            if (longs == null)
                Console.WriteLine("Only Work Ingame. No Entities Found");
            foreach (long num in longs)
            {
                string str = num.ToString("X");
                Byte[] numArray = MemLib.AhReadMeFucker((num + 44L).ToString("X"), 4L);
                MemLib.WriteMemory((num + 40L).ToString("X"), "int", BitConverter.ToInt32(numArray, 0).ToString());
            }
            status.Text = "Aimbot Done";
        }

        

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private async void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            await Main.ChangeMem("Ae 1d 2d 4d 4D 1S 3d 3A", "00 00 00 00 00 00", "1");
        }

    }
}
