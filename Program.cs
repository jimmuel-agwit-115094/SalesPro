using Microsoft.Extensions.DependencyInjection;
using SalesPro.Forms;
using SalesPro.Services;
using System;
using System.Windows.Forms;

namespace SalesPro
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

            Application.Run(new LoginForm());
        }
    }
}
