using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PublicTrasportDashboard.DAL
{
    public class Location
    {
        public int Id { get; set; }
        public int BusId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime UpdatedOn { get; set; }
    }

    public class Bus
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int PassengerCapacity { get; set; }
        public int FuelCapacity { get; set; }
    }

    public class Incidents
    {
        public int Id { get; set; }
        public string IncedentType { get; set; }
    }

    public class BusIncedents
    {
        public int BusId { get; set; }
        public int IncedentId { get; set; }
    }

    public class Maintenace
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }

    public class BusMaintenanceSchedule
    {
        public int BusId { get; set; }
        public int MaintenenceId { get; set; }
        public DateTime LastServicedDate { get; set; }
        public DateTime NextMaintenanceDate { get; set; }
        public string Status { get; set; }
    }

    public class Occupancy
    {
        public int BusId { get; set; }
        public int CurrentOccupancy { get; set; }
        public string ColorCode { get; set; }
    }
}