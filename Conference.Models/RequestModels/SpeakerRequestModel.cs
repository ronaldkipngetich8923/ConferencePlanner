using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Models.RequestModels
{
   public class SpeakerRequestModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public virtual string WebSite { get; set; }   
        public Guid SessionId { get; set; }
    }
}
