using _BerberApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _BerberApp
{
    internal static class Program
    {
        // Giriş yapan kişinin bilgilerini tutmak için kullanıyorum.
        public static Kullanici kullanici = new Kullanici();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmGiris());
        }
    }
}
