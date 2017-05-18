﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;

namespace SodaApiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient webclient = new WebClient();
            //var data = webclient.DownloadString("https://data.healthcare.gov/resource/enx3-h2qp.json?$limit=50000&$offset=1000");
            var data = webclient.DownloadString("https://data.healthcare.gov/resource/enx3-h2qp.json?$limit=50");
            var client = new RestClient("https://data.healthcare.gov/");
            // client.Authenticator = new HttpBasicAuthenticator(username, password);

            var request = new RestRequest("resource/enx3-h2qp.json?$limit=10&$offset=10000000", Method.GET);
            //request.AddParameter("name", "value"); // adds to POST or URL querystring based on Method
            //request.AddUrlSegment("id", "123"); // replaces matching token in request.Resource
            // easily add HTTP Headers
            //request.AddHeader("header", "value");
            // add files to upload (works with compatible verbs)
            // request.AddFile(path);
            // execute the request
            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as string

            // or automatically deserialize result
            // return content type is sniffed but can be explicitly set via RestClient.AddHandler();
            //RestResponse<Person> response2 = client.Execute<Person>(request);
            //var name = response2.Data.Name;

            // easy async support
            //client.ExecuteAsync(request, response =>
            //{
            //    Console.WriteLine(response.Content);
            //});

            // async with deserialization
            //var asyncHandle = client.ExecuteAsync<Person>(request, response =>
            //{
            //    Console.WriteLine(response.Data.Name);
            //});

            // abort the request on demand
            // asyncHandle.Abort();

            var result = (List<RootObject>)Newtonsoft.Json.JsonConvert.DeserializeObject(content, typeof(List<RootObject>));

        }
    }
}
