using PublicTrasportDashboard.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTrasportDashboard.Interfaces
{
    public interface IMaintenanceService : IDisposable
    {
        void GetMaintenences();
        void GetMaintenanceById(int id);
        BusMaintenanceSchedule GetBusMaintenanceSchedule(int busId);
    }
}
