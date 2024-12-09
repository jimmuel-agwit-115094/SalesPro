using Microsoft.Extensions.DependencyInjection;
using POS_Generic.Helpers;
using SalesPro.Accessors;
using SalesPro.Forms;
using SalesPro.Forms.Transactions;
using SalesPro.Models;
using SalesPro.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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


        private static void ConfigureServices(IServiceCollection services)
        {
            // Register the services and dependencies here
            services.AddScoped<DatabaseContext>();
            services.AddScoped<Accessor<TransactionModel>>();
            services.AddScoped<Accessor<TransactionLogModel>>();
            services.AddScoped<TransactionAccessor>();
            services.AddScoped<TransactionLogAccessor>();
            services.AddScoped<TransactionService>();

            // Register your form or UI
            services.AddScoped<MainForm>();
            // Registering the form
            services.AddScoped<TransactionDetailsForm>();
            services.AddScoped<TransactionForm>();
        }
    }
}
