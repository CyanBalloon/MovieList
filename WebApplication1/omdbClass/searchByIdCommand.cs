using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMovie.omdbClass
{
    public class searchByIdCommand : searchCommand
    {
        private string id;

        public searchByIdCommand(string id)
        {
            this.id = id;
        }

        public string execute()
        {
            return "i=" + id;
        }
    }
}