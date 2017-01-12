using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HubSpotRestClient.Models
{
    public class Model
    {
        public string GetPath()
        {
            if (this is Company)
                return "/companies/v2/companies";
            if (this is Contact)
                return "/contacts/v1/contact";
            throw new NotImplementedException("This item is not yet implemented.");
        }

        public string ToJson()
        {
            var allProp = this.GetType().GetProperties();
            var suffix = "";
            if (this is Company)
                suffix = "name";
            if (this is Contact)
                suffix = "property";
            var jsonBody = "{\"properties\":[";
            foreach (var prop in allProp)
            {
                if (prop.GetValue(this, null) != null)
                    jsonBody += "{\"" + suffix + "\":\"" + prop.Name + "\", \"value\":\"" + prop.GetValue(this, null).ToString() + "\"},";
            }
            jsonBody += "]}";
            jsonBody = jsonBody.Replace(",]", "]");
            return jsonBody;
        }
    }
}
