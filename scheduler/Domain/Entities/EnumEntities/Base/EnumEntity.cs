using scheduler.Domain.Entities.Base;

namespace scheduler.Domain.Entities.EnumEntities.Base
{
    public class EnumEntity : Entity
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}