using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using HtmlAgilityPack;
using System.Collections;
using System.Web;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using UnityEngine;
using Microsoft.CSharp;

namespace SpraiseHtml
{
    public class Result { public string title { get; set; } public string link { get; set; } public string snippet { get; set; } }
    public class Class1
    {
        public string next_index, search_terms;
        string cx = "000758091533793376942:vei8xgbnvio";
        string key = "AIzaSyBy84tCaoDdsWp1OtzeObhxGpTYku0FwJ4";

        public List<Result> Search(string search)
        {
            List<Result> results = new List<Result>();
            var url = ("https://www.googleapis.com/customsearch/v1?key=" + key + "&cx=" + cx + "&q=" + search);
            var request = WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseString = reader.ReadToEnd();
            dynamic jsonData = JsonConvert.DeserializeObject(responseString);

            next_index = jsonData["queries"]["nextPage"][0]["startIndex"];
            search_terms = jsonData["queries"]["nextPage"][0]["searchTerms"];


            foreach (var x in jsonData.items)
            {
                results.Add(new Result
                {
                    title   = x.title,
                    link    = x.link,
                    snippet = x.snippet,
                });
            }
            return results;
        }

        public List<Result> nextPage(string search, string next)
        {
            List<Result> results = new List<Result>();
            var url = ("https://www.googleapis.com/customsearch/v1?key=" + key + "&cx=" + cx + "&q=" + search + "&start=" + next);
            var request = WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseString = reader.ReadToEnd();
            dynamic jsonData = JsonConvert.DeserializeObject(responseString);

            next_index = jsonData["queries"]["nextPage"][0]["startIndex"];
            search_terms = jsonData["queries"]["nextPage"][0]["searchTerms"];

            foreach (var x in jsonData.items)
            {
                results.Add(new Result
                {
                    title = x.title,
                    link = x.link,
                    snippet = x.snippet,
                });
            }
            return results;
        }


    }
}

