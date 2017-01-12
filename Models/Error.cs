using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HubSpotRestClient.Models
{
    public class Error
    {
        public string status { get; set; }
        public string message { get; set; }
        public string correlationId { get; set; }
        public string requestId { get; set; }
    }
}
