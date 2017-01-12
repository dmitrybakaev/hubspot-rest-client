using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HubSpotRestClient.Interfaces
{
    public interface IHubSpotEntity
    {
        string ToJson();
        string GetPath();
    }
}
