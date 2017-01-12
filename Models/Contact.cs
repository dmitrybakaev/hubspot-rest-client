using HubSpotRestClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HubSpotRestClient.Models
{
    public class Contact : Model, IHubSpotEntity
    {
        public String email { get; set; }
        public String firstName { get; set; }
        public String lastname { get; set; }
        public String website { get; set; }
        public String company { get; set; }
        public String phone { get; set; }
        public String address { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String zip { get; set; }
    }

    
}
