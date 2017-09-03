using System;
using System.Configuration;
using System.Data.Entity.Infrastructure;

namespace scheduler
{
    public partial class SchedulerDbContextFactory : IDbContextFactory<SchedulerDbContext>
    {
        public SchedulerDbContext Create()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SchedulerDbContext"].ConnectionString;
            var connectionStrings = ConfigurationManager.ConnectionStrings;

            foreach (ConnectionStringSettings connectionStringSettings in connectionStrings)
            {
                Console.WriteLine(connectionStringSettings.Name);
                Console.WriteLine(connectionStringSettings.ProviderName);
                Console.WriteLine(connectionStringSettings.ConnectionString);
            }

            var conString = ConfigurationManager.ConnectionStrings["SchedulerDbContext"];
            if (conString != null)
                Console.WriteLine(conString);

            //Console.WriteLine(connectionString);

            return new SchedulerDbContext();
        }
    }
}