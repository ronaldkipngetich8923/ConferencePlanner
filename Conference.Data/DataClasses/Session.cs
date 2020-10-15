using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Data.DataClasses
{
    public class Session
    {
        public Guid Id { get; set; }   
        public string Title { get; set; }
       
        public virtual string Abstract { get; set; }

        public virtual DateTimeOffset? StartTime { get; set; }

        public virtual DateTimeOffset? EndTime { get; set; }

        // Bonus points to those who can figure out why this is written this way
        public TimeSpan Duration => EndTime?.Subtract(StartTime ?? EndTime ?? DateTimeOffset.MinValue) ?? TimeSpan.Zero;

        public int? TrackId { get; set; }
        public Track Track { get; set; }
    }
}
