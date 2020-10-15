using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Models.ResponseModels
{
    public class WebService
    {
        public string ApiUrl { get; set; }
        public string OauthUrl { get; set; }
        public string SigningSecret { get; set; }
    }
}
