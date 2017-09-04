using System.ComponentModel.DataAnnotations.Schema;
using scheduler.Domain.Entities;
using scheduler.Domain.ValueObjects.Base;

namespace scheduler.Domain.ValueObjects
{
    public class Position : ValueObject
    {
        #region navigationProperties

        public string Name { get; set; }

        public string Area { get; set; }

        public int LocationId { get; set; }

        public virtual Location Location { get; set; }

        #endregion
    }
}