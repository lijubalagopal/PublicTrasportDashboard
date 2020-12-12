using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PublicTrasportDashboard.Controllers
{
    public class LocationController : ApiController
    {
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        public string Patch(int id)
        {
            return "";
        }
    }
}
