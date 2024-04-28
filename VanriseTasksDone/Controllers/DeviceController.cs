using Microsoft.AspNetCore.Mvc;
using System;
using System;
using System.Collections;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using VanriseTask34.Models;
using VanriseTask34.Services;
using VanriseTasksDone.IServices;

namespace VanriseTasksDone.Controller
{
    [RoutePrefix("api/Device")]
    public class DeviceController : ApiController
    {
        private readonly IDeviceService deviceService;
       
        public DeviceController(IDeviceService deviceService)
        {
            this.deviceService = deviceService;
        }
        [Route("")]
        [HttpGet]
        public async Task<IHttpActionResult> GetDevices()
        {
            var devices = deviceService.GetAllDevices();
            return Ok(devices);
        }
        [Route("{id}")]
        [HttpGet]
        public async Task<IHttpActionResult> GetDeviceById(int id)
        {
            var devices = deviceService.GetDeviceById(id);
            return Ok(devices);
        }

    }
}