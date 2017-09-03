using System.ComponentModel.DataAnnotations.Schema;

namespace scheduler.Database.Enums.Base
{
    public class ValueObject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}