using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asset_Management_Alpha
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SFG());
            //Application.Run(new ConnectToDataBaseForm());
            //Application.Run(new LogIn_Form());
            Application.Run(new Server_Form());
        }
    }
}
