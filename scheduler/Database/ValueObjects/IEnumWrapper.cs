using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using scheduler.Enums.Extensions;

namespace scheduler.Enums
{
    public class IEnumWrapper<TEnum, T> where T : new()
    {
        private IEnumWrapper(TEnum @enum)
        {
            Id = (int) Enum.Parse(typeof(TEnum), @enum.ToString());
            Name = @enum.ToString();
            Description = @enum.GetEnumDescription();
        }

        protected IEnumWrapper()
        {
        } //For EF

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        public static T ConvertToType()
        {
            return (T) TEnum;
        }

        public static TEnum ToEnum(T type)
        {
            return (TEnum) type;
        }

        public static T ToClass(TEnum @enum)
        {
            return new T
            {
                
            };
        }

        public static implicit operator int(IEnumWrapper<TEnum, T> faculty)
        {
            return faculty.Id;
        }
    }
}