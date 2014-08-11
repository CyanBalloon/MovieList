using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.omdbClass
{
    public class searchByTitleCommand : searchCommand
    {
        private string title;

        public searchByTitleCommand(string title)
        {
            this.title = title;
        }

        public string execute()
        {
            return "query=" + title;
        }
    }
}