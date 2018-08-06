using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.Remoting;

namespace DemoService
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            RemotingConfiguration.Configure("DemoService.exe.config");

            RemotingServices.Marshal(new TestService(), "TestService");
            Application.Run(new Form1());
        }
    }
}
