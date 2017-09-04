using System;
using System.Data.Entity.Infrastructure;

namespace scheduler.Infrastructure.Database.EntityFramework
{
    public interface ISchedulerDbContext : IDisposable, IObjectContextAdapter
    {
    }
}