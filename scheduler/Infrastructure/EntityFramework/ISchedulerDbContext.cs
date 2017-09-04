using System;
using System.Data.Entity.Infrastructure;

namespace scheduler.Infrastructure.EntityFramework
{
    public interface ISchedulerDbContext : IDisposable, IObjectContextAdapter
    {
    }
}