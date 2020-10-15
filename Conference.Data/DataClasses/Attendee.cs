using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Data.DataClasses
{
    public class Attendee
    {
        public Guid Id { get; set; }       
        public virtual string FirstName { get; set; }  
        public virtual string LastName { get; set; }      
        public string UserName { get; set; }
      
        public virtual string EmailAddress { get; set; }
        public Guid SessionId { get; set; }
        public Session Session { get; set; }
    }
}
