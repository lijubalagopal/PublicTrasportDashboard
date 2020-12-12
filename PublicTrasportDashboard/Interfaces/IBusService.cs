using PublicTrasportDashboard.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace PublicTrasportDashboard.Interfaces
{
    public interface IBusService : IDisposable
    {
        Task<List<Bus>> GetAll();
        Task<Bus> GetById(int id);
        Task<bool> AddBus(Bus bus);
        Task<bool> UpdateBus(Bus bus);
        Task<bool> DeleteBus(Bus bus);
    }
}
