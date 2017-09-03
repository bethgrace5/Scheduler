using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using scheduler.Enums.Extensions;

namespace scheduler.Enums
{
    public class EnumUtils : EnumClassUtils<Enum>
    {
    }

    public abstract class EnumClassUtils<TClass> where TClass : class
    {
        protected EnumClassUtils(Enum @enum)
        {
            Id = (int) Enum.Parse(typeof(TClass), @enum.ToString());
            Name = @enum.ToString();
            Description = @enum.GetEnumDescription();
        }

        protected EnumClassUtils()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public static TEnum Parse<TEnum>(string value)
            where TEnum : struct, TClass
        {
            return (TEnum) Enum.Parse(typeof(TEnum), value);
        }
    }
}