using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicTrasportDashboard.DAL
{
    public interface IBusDAL
    {
        Task<List<Bus>> GetAll();
        Task<Bus> GetById(int id);
        Task<bool> AddBus(Bus bus);
        Task<bool> UpdateBus(Bus bus);
        Task<bool> DeleteBus(Bus bus);
    }
}
