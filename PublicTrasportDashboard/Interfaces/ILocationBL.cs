using PublicTrasportDashboard.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTrasportDashboard.Interfaces
{
    public interface ILocationService : IDisposable
    {
        string GetLocation(int busId);
        bool UpdateLocation(int busId, Location location);
    }
}
