# hubspot-rest-client
.NET bindings for the HubSpot CRM

This is a sketch of C# rest client for the HubSpot. Current version supports only one opertaion: submit contacts or companies.
Can be downloaded from NUget: **PM> Install-Package HubSpotRestClient**

Usage example
--------------

   
      var client = new HubSpotClient("your-api-key");
      client.Add(new Company
      {
                name = "Company Name",
                description = "Company description"
      });
