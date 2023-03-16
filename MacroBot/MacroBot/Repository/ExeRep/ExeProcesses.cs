using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroBot.Repository
{
    public class ExeProcesses
    {
        [DllImport("User32.dll", SetLastError = true)]
        static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        [DllImport("User32.dll")]
        static extern int SetForegroundWindow(IntPtr point);

        public Process p = null;

        public void setProccess(string exeName)
        {
            p = Process.GetProcessesByName(exeName).FirstOrDefault();
        }

        public bool ekranionegetir()
        {
            if (p != null)
            {
                IntPtr h = p.MainWindowHandle;
                SwitchToThisWindow(h, true);
                return true;
            }
            else return false;
        }
        public void getMyScreen()
        {
            Process myProcess = Process.GetCurrentProcess();
            IntPtr h = myProcess.MainWindowHandle;
            SwitchToThisWindow(h, true);
        }
    }
}
