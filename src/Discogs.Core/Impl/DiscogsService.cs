using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Discogs.Core.Dto;
using Discogs.Core.Interfaces;
using RestSharp;
using RestSharp.Deserializers;

namespace Discogs.Core.Impl
{
    public class DiscogsService : IDiscogsService
    {
        private readonly DiscogsSettings discogsSettings;
        private readonly RestClient restClient;

        public DiscogsService(DiscogsSettings discogsSettings)
        {
            this.discogsSettings = discogsSettings;
            this.restClient = new RestClient(discogsSettings.DiscogsUrl);
        }

        private RestRequest CreateDefaultRequest(string commandName, string responseFormat = "json")
        {
            var request = new RestRequest
                              {
                                  RootElement = "resp",
                                  Method = Method.GET,
                                  Resource = commandName.Contains("?") ? String.Format("{0}&f={1}&api_key={2}", commandName, responseFormat, discogsSettings.ApiKey) : String.Format("{0}?f={1}&api_key={2}", commandName, responseFormat, discogsSettings.ApiKey)
                              };

            return request;
        }

        private RestRequest CreateQueryRequest(string commandName, Dictionary<string, string> queryString, string responseFormat = "json")
        {
            var querystrings = new StringBuilder();

            if(queryString != null && queryString.Count() > 0)
            {
                foreach(var kvp in queryString)
                {
                    querystrings.AppendFormat("&{0}={1}", kvp.Key, kvp.Value);
                }
            }

            var request = new RestRequest
                              {
                                  RootElement = "resp",
                                  Method = Method.GET,
                                  Resource = commandName.Contains("?") ? String.Format("{0}&f={1}&api_key={2}{3}", commandName, responseFormat, discogsSettings.ApiKey, querystrings) : String.Format("{0}?f={1}&api_key={2}{3}", commandName, responseFormat, discogsSettings.ApiKey, querystrings)
                              };

            return request;
        }

        private T ExecuteJsonRequest<T>(RestRequest request, string rootElement) where T : new()
        {
            var response = restClient.Execute(request);
            if (response == null)
                throw new ApplicationException("Response was null");

            var json = new JsonDeserializer { RootElement = rootElement };

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                return json.Deserialize<T>(response);
            }

            if (response.StatusCode != HttpStatusCode.OK)
                throw new ApplicationException(String.Format("Response was not ok. Response is {0}, {1}",
                                                             response.StatusCode, response.StatusDescription));

            return json.Deserialize<T>(response);
        }

        public Artist Artist(string artistName, bool includeReleases = false)
        {
            var requestString = string.Format("artist/{0}", artistName);

            var querystrings = new Dictionary<string, string>();

            if (includeReleases)
                querystrings.Add("releases", "1");

           var request = includeReleases && querystrings.Count > 0
                              ? CreateQueryRequest(requestString, querystrings)
                              : CreateDefaultRequest(requestString);
            var response = ExecuteJsonRequest<Resp>(request, "resp");

            return response.Artist;
        }

        public Release Release(int releaseId)
        {
            var request = CreateDefaultRequest(string.Format("release/{0}", releaseId));
            var response = ExecuteJsonRequest<Resp>(request, "resp");

            return response.Release;
        }

        public Master MasterRelease(int masterReleaseId)
        {
            var request = CreateDefaultRequest(string.Format("master/{0}", masterReleaseId));
            var response = ExecuteJsonRequest<Resp>(request, "resp");

            return response.Master;
        }

        public Label Label(string label, bool includeReleases = false)
        {
            var requestString = string.Format("label/{0}", label);

            var querystrings = new Dictionary<string, string>();
            
            if(includeReleases)
                querystrings.Add("releases", "1");

            var request = includeReleases && querystrings.Count > 0
                              ? CreateQueryRequest(requestString, querystrings)
                              : CreateDefaultRequest(requestString);

            var response = ExecuteJsonRequest<Resp>(request, "resp");

            return response.Label;
        }

        public Search Search(string query, SearchTypes searchType = SearchTypes.all, int page = 1)
        {
            if (string.IsNullOrEmpty(query))
                return null;

            var requestString = string.Format("search?q={0}", query);
            
            var querystrings = new Dictionary<string, string>();

            if(searchType != SearchTypes.all)
                querystrings.Add("type", Enum.GetName(typeof(SearchTypes), searchType));

            if(page > 1)
                querystrings.Add("page", page.ToString());

            var request = querystrings.Count > 0
                              ? CreateQueryRequest(requestString, querystrings)
                              : CreateDefaultRequest(requestString);

            var response = ExecuteJsonRequest<Resp>(request, "resp");

            return response.Search;
        }
    }
}
