using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_BDshop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static string Brands;
        public static string Nameproduct;
        public static string Price;
        public static string Amount;
        public static string Username;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
