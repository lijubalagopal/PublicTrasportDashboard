using PublicTrasportDashboard.DAL;
using PublicTrasportDashboard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PublicTrasportDashboard.Controllers
{
    public class BusController : ApiController
    {
        IBusService _busService;
        public BusController(IBusService busService)
        {
            this._busService = busService;
        }

        public IHttpActionResult Get()
        {
            var buses = _busService.GetAll();
            return Ok(buses);
        }

        public IHttpActionResult Post([FromBody] Bus bus)
        {
            var isAdded = _busService.AddBus(bus);
            return Ok(isAdded);
        }
    }
}
