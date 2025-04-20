using BlackGenerator_XS.Forms;
using BlackGenerator_XS.Logger;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackGenerator_XS
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Logger.Logger.LoggerDebug("BlackLauncherXS. Testing.");

            Thread.Sleep(1000);
            Application.Run(new LauncherForm());
            FreeConsole();
            
        }
        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();
    }
}
