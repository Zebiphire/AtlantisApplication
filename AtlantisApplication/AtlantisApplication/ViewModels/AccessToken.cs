using System;
using System.Collections.Generic;
using System.Text;

namespace AtlantisApplication.ViewModels
{
    public class AccessToken
    {
        public string client_id { get; set; }
        public string grant_type { get; set; }
        public string code { get; set; }
        public string client_secret { get; set; }
    }
}
