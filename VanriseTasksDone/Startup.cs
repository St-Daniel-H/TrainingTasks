using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using VanriseTask34.Services;
using VanriseTasksDone.IServices;

[assembly: OwinStartup(typeof(VanriseTasksDone.Startup))]

namespace VanriseTasksDone
{
    public partial class Startup
    {
        public void Configuration(IServiceCollection services)
        
        {
            services.AddScoped<IDeviceService, DeviceService>();
        }
    }
}
