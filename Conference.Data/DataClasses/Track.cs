using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Data.DataClasses
{
    public class Track
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}
