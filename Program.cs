using Microsoft.Extensions.DependencyInjection;
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

        public static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<TransactionService>();
            return services.BuildServiceProvider();
        }
    }
}
