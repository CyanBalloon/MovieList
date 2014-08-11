using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.omdbClass
{
    public class searchByYearCommand : searchCommand
    {
        private int year;

        public searchByYearCommand(int year)
        {
            this.year = year;
        }

        public string execute()
        {
            return "primary_release_year=" + year;
        }
    }
}