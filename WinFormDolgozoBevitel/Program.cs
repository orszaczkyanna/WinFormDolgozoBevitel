using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormDolgozoBevitel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static MainForm mainForm;
        public static FormBevitel formBevitel;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            mainForm = new MainForm();
            formBevitel = new FormBevitel();
            Application.Run(mainForm);
        }
    }
}
