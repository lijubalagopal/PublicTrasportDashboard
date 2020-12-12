using PublicTrasportDashboard.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTrasportDashboard.Interfaces
{
    public interface IIncidentService : IDisposable
    {
        void GetIncidents();
        void GetIncidentById(int id);
        void GetBusIncidentById(int busId);
        void UpdateIncident(int busId, int incidentId);
    }
}
