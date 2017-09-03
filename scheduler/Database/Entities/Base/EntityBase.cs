using System;

namespace scheduler.Database.Entities.Base
{
    public class EntityBase<TId>
    {
        public EntityBase()
        {
            DateCreated = DateTime.Now;
        }

        public TId Id { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateDeleted { get; set; }
    }
}