using PublicTrasportDashboard.DAL;
using PublicTrasportDashboard.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PublicTrasportDashboard.Business
{
    public class BusService : IBusService
    {
        readonly IBusDAL _busDAL;
        public BusService(IBusDAL busDAL)
        {
            this._busDAL = busDAL;
        }
        async public Task<bool> AddBus(Bus bus)
        {
            var isAdded = await _busDAL.AddBus(bus);
            return await Task.FromResult(isAdded);
        }

        public Task<bool> DeleteBus(Bus bus)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<Bus>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Bus> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateBus(Bus bus)
        {
            throw new NotImplementedException();
        }
    }
}