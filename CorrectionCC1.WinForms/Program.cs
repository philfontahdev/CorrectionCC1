using CorrectionCC1.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrectionCC1.WinForms
{
    static class Program
    {
        public static User CurrentUser { get; set; } 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new FormPrevie().Show();
            Application.Run();
        }
    }
}
