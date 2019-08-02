using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternshipAPI.Repository
{
    public class HelloWorldRepository
    {
        public string Say_Hello(string name)
        {
            return "Salut,"+name+"!";
        }
    }
}