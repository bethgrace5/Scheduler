using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using scheduler.Database.Entities.EnumEntities.Base;

namespace scheduler.Database.ValueObjects.Extensions
{
    public static class Extensions
    {
        public static string GetEnumDescription<TEnum>(this TEnum item)
        {
            return item.GetType()
                       .GetField(item.ToString())
                       .GetCustomAttributes(typeof(DescriptionAttribute), false)
                       .Cast<DescriptionAttribute>()
                       .FirstOrDefault()?.Description ?? string.Empty;
        }

        public static void SeedEnumValues<T, TEnum>(this IDbSet<T> dbSet)
            where T : EnumEntity, new()
        {
            var values = Enum.GetValues(typeof(TEnum));

            foreach (var val in values)
            {


                var @object = new T
                {
                    Id = (int) Enum.Parse(typeof(TEnum), val.ToString()),
                    Name = val.ToString(),
                    Description = val.GetEnumDescription()
                };

                dbSet.AddOrUpdate(@object);
            }
        }
    }
}