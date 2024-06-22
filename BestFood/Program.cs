using BestFood.DAL;
using System;
using System.IO;
using Microsoft.Extensions.Configuration;


namespace BestFood
{
    internal static class Program
    {
        private static IConfiguration? Configuration { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Build configuration
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("secrets.json", optional: true, reloadOnChange: true)
                .Build();

            // Pass the configuration to the DAL
            AppSqlHandler.Initialize(Configuration.GetConnectionString("BestFoodDatabase")!);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            new Seed().EnsureExists();
            //new Seed(true,true).EnsureExists();
            Application.Run(new UILogin());
            //Application.Run(new UIAdmin());

        }
    }
}