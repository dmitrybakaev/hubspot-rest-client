using HubSpotRestClient.Exceptions;
using HubSpotRestClient.Models;
using HubSpotRestClient.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace HubSpotRestClient
{
    public class HubSpotClient
    {
        private string _apiKey;
        private RestClient _restClient;

        /// <summary>
        /// Constructor: Currently supports only API Key authentication method
        /// </summary>
        /// <param name="ApiKey">Can be retireved from HubSpot web app</param>
        public HubSpotClient(string ApiKey)
        {
            this._apiKey = ApiKey;
            _restClient = new RestClient("https://api.hubapi.com");

        }

        /// <summary>
        /// Add Client or Company to the Hubspot
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public void Add(IHubSpotEntity item)
        {
            var request = new RestRequest(item.GetPath() + @"?hapikey=" + _apiKey, Method.POST);
            request.Method = Method.POST;
            request.AddHeader("Accept", "application/json");
            request.AddParameter("application/json", item.ToJson(), ParameterType.RequestBody);

            var response = _restClient.Execute(request);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var jsonResponse = JsonConvert.DeserializeObject<Error>(response.Content);
                throw new RestServerException(jsonResponse.message);
            }           
        }

      

    }
}
