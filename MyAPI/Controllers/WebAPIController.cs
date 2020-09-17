using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyAPI.Controllers
{
    public class WebAPIController : ApiController
    {
        public string Get()
        {
            return "Welcome to the Web API";
        }

        public List <string> Get(int id)
        {
            return new List<string>
            {
                "Data 1",
                "Data 2"
            };
        }
    }
}
