using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class omdbMovie
    {
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public int id { get; set; }
        public string original_title { get; set; }

        [DataType(DataType.Date), DisplayFormat( DataFormatString="{0:dd/MMMM/yyyy}")]
        public string release_date { get; set; }

        public string poster_path { get; set; }
        public double popularity { get; set; }
        public string title { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }
    }
}