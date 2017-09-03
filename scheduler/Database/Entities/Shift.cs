﻿using System;
using scheduler.Database.Entities.Base;

namespace scheduler.Database.Entities
{
    public class Shift : Entity
    {
        public string Name { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime IneffectiveDate { get; set; }
        public DateTime MondayStart { get; set; }
        public DateTime MondayEnd { get; set; }
        public DateTime TuesdayStart { get; set; }
        public DateTime TuesdayEnd { get; set; }
        public DateTime WednesdayStart { get; set; }
        public DateTime WednesdayEnd { get; set; }
        public DateTime ThursdayStart { get; set; }
        public DateTime ThursdayEnd { get; set; }
        public DateTime FridayStart { get; set; }
        public DateTime FridayEnd { get; set; }
        public DateTime SaturdayStart { get; set; }
        public DateTime SaturdayEnd { get; set; }
        public DateTime SundayStart { get; set; }
        public DateTime SundayEnd { get; set; }
        public int ViewIndex { get; set; }

        #region navigationProperties

        public int PositionId { get; set; }

        public virtual Position Position { get; set; }

        public int LocationId { get; set; }

        public virtual Location Location { get; set; }

        #endregion
    }
}