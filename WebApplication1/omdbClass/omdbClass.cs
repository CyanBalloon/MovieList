using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcMovie.Models;
using System.Net;
using System.IO;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace MvcMovie.omdbClass
{
    public class omdbClass
    {
        private static omdbClass omdbInstance;
        private static List<searchCommand> searchCommands = new List<searchCommand>();

        private omdbClass() { }

        public static omdbClass Instance
        {
            get
            {
                if (omdbInstance == null)
                {
                    omdbInstance = new omdbClass();
                }
                return omdbInstance;
            }
        }

        public void addSearchCommand(searchCommand c)
        {
            searchCommands.Add(c);
        }

        public List<omdbMovie> executeSearch() {
            string searchUrl = GlobalVariables.APIURL + "search/movie?" + GlobalVariables.APIKEY;

            // Generate search URL
            foreach (searchCommand s in searchCommands) {
                searchUrl += "&" + s.execute();
            }

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(searchUrl);
            wrGETURL.ContentType = "application/json; charset=utf-8";

            StreamReader objStream = new StreamReader(wrGETURL.GetResponse().GetResponseStream());

            string responseData = objStream.ReadToEnd();

            omdbResponseClass omdbResponse = JsonConvert.DeserializeObject<omdbResponseClass>(responseData);

            foreach (omdbMovie m in omdbResponse.results)
            {
                m.poster_path = "https://image.tmdb.org/t/p/w130/" + m.poster_path;
            }

            return omdbResponse.results;
        }
    }
}