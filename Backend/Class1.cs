﻿using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Backend
{
    public class Class1
    {
        
    }

    public class GoogleSearchResult { 
        public string title { get; set; } 
        public string link { get; set; } 
        public string snippet { get; set; } 
    }

    public class GoogleSearch
    {
        // string cx = "000758091533793376942:vei8xgbnvio";
        // string key = "AIzaSyBy84tCaoDdsWp1OtzeObhxGpTYku0FwJ4";
        private string CX;
        private string KEY;
        private string URL="https://www.googleapis.com/customsearch/v1?key=";
        public string next_index, search_terms;

        public GoogleSearch(string cx, string key)
        {
            CX=cx;
            KEY=key;
        }

        public List<GoogleSearchResult> Search(string search, string type="")
        {
            List<GoogleSearchResult> results = new List<GoogleSearchResult>();
            var url= "";
            if(type!=""){
                url = (URL + KEY + "&cx=" + CX + "&q=" + search + "&searchType=image");
            }else{
                url = (URL + KEY + "&cx=" + CX + "&q=" + search);
            }
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
                results.Add(new GoogleSearchResult
                {
                    title   = x.title,
                    link    = x.link,
                    snippet = x.snippet,
                });
            }
            return results;
        }

        public List<GoogleSearchResult> nextPage(string search, string next, string type="")
        {
            List<GoogleSearchResult> results = new List<GoogleSearchResult>();
            var url="";
            if(type!=""){
                url = (URL + KEY + "&cx=" + CX + "&q=" + search + "&start=" + next + "&searchType=image");
            }else{
                url = (URL + KEY + "&cx=" + CX + "&q=" + search + "&start=" + next);
            }
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
                results.Add(new GoogleSearchResult
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
