using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Data.DataClasses
{
   public class Speaker
    {
        public Guid Id { get; set; }      
        public string Name { get; set; }      
        public string Bio { get; set; }
        public virtual string WebSite { get; set; }
        public Session Session { get; set; }
        public Guid SessionId { get; set; }
    }
}
