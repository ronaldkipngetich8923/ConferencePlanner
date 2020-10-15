 using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Models.ResponseModels
{
    public class StatusResponseModel
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public Guid ID { get; set; }
    }
}
