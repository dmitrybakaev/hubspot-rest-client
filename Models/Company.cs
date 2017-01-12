using HubSpotRestClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HubSpotRestClient.Models
{
    public class Company : Model, IHubSpotEntity
    {
        public String name { get; set; }
        public String description { get; set; }

       
    }



}
