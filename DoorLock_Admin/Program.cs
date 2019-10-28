using DoorLock_Library.APIConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorLock_Admin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            SMSApiHelper.InitializeClient("https://tadhackapi.azurewebsites.net/api/");
            ApiHelper.InitializeClient("https://lod.azurewebsites.net/api/");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
