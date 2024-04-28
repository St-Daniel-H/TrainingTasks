using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanriseTask34.Models;

namespace VanriseTasksDone.IServices
{
    public interface IDeviceService
    {
         Task<IEnumerable<Device>> GetAllDevices();
        Task<Device> GetDeviceById(int id);
        Task<Device> AddDevice(Device device);
        Task<Device> UpdateDevice(Device device);
        Task<Device> DeleteDevice(int id);
    }
}
