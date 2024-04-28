using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using VanriseTask34.Models;
using VanriseTasksDone.IServices;

namespace VanriseTask34.Services
{
    public class DeviceService :IDeviceService
    {
        private readonly VanriseContext _dbContext;
        public DeviceService(VanriseContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<Device> AddDevice(Device device)
        {
            _dbContext.Devices.Add(device);
           await  _dbContext.SaveChangesAsync();
           return device;
        }

        public Task<Device> DeleteDevice(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Device>> GetAllDevices()
        {
            return _dbContext.Devices;
        }
        public async Task<Device> GetDeviceById(int id)
        {
            return _dbContext.Devices.Where(x=>x.Id == id).FirstOrDefault();
        }

        public Task<Device> UpdateDevice(Device device)
        {
            throw new NotImplementedException();
        }
    }
}