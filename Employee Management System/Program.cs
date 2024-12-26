using Employee_Management_System.Data;
using Employee_Management_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ApplyMigrationsAndSeedData();
            Application.Run(new Login());
        }

        private static void ApplyMigrationsAndSeedData()
        {
            // Create the DbContext
            using (var context = new CompanyDB())
            {
                // Apply migrations
                context.Database.Migrate();

                // Seed data if necessary
                var seeder = new DataSeeder(context);
                seeder.SeedRandomData(5); //5 random employees
            }
        }

    }
}