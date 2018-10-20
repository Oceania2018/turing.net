using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Turing.NET
{
    public class TuringAgent
    {
        private string apiKey = "";
        private string userId = "";
        private string url = "";

        public TuringAgent(IConfiguration config)
        {
            if(config.GetSection("turingAi:url").Value == null)
            {
                Console.WriteLine("Missing turingAi.json settings");
                return;
            }

            apiKey = config.GetSection("turingAi:apiKey").Value;
            userId = config.GetSection("turingAi:userId").Value;
            url = config.GetSection("turingAi:url").Value;
        }

        public TuringResponse Request(TuringRequest req)
        {
            if (String.IsNullOrEmpty(url))
            {
                url = "http://openapi.tuling123.com";
            }

            req.UserInfo = new TuringRequestUserInfo
            {
                ApiKey = apiKey,
                UserId = userId
            };

            var client = new RestClient(url);

            var rest = new RestRequest("/openapi/api/v2", Method.POST);
            rest.RequestFormat = DataFormat.Json;
            string json = JsonConvert.SerializeObject(req,
                new JsonSerializerSettings
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });
            rest.AddParameter("application/json", json, ParameterType.RequestBody);

            var result = client.Execute(rest);

            return JsonConvert.DeserializeObject<TuringResponse>(result.Content);
        }
    }
}
