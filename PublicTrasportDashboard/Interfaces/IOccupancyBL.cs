using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTrasportDashboard.Interfaces
{
    public interface IOccupancyService : IDisposable
    {
        void UpdateOccupancy(int busId, int currentCapacity);
    }
}
