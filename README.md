# hubspot-rest-client
.NET bindings for the HubSpot CRM
This is a sketch if C# Rest client for the HubSpot. Current version supports only one opertaion: submit contacts and companies.

Usage examples
--------------

   
      var client = new HubSpotClient("your-api-key");
      client.Add(new Company
      {
                name = "Company Name",
                description = "Company description"
      });
