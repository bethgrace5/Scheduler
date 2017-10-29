using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using scheduler.Domain.Entities.Enums.Base;

namespace scheduler.Domain.Entities.Enums.Extensions
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

        /// <summary>
        /// Takes regular enum (with a resource description), converts it's corresponding <see cref="EnumEntity"/>,
        /// and stores it in the database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="dbSet"></param>
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