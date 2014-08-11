using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.omdbClass
{
    public class omdbResponseClass
    {
        public int page { get; set; }
        public List<omdbMovie> results { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
    }
}