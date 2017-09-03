using System.ComponentModel.DataAnnotations.Schema;
using scheduler.Database.Entities.Base;

namespace scheduler.Database.Entities.EnumEntities.Base
{
    public class EnumEntity : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}