using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PublicTrasportDashboard.DAL
{
    public class BusDAL : IBusDAL
    {
        async public Task<bool> AddBus(Bus bus)
        {
            throw new NotImplementedException();
        }

        async public Task<bool> DeleteBus(Bus bus)
        {
            throw new NotImplementedException();
        }

        async public Task<List<Bus>> GetAll()
        {
            throw new NotImplementedException();
        }

        async public Task<Bus> GetById(int id)
        {
            throw new NotImplementedException();
        }

        async public Task<bool> UpdateBus(Bus bus)
        {
            throw new NotImplementedException();
        }
    }
}