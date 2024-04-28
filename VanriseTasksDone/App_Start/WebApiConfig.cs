using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using Unity;
using Unity.Lifetime;
using Unity.WebApi;
using VanriseTask34.Services;
using VanriseTasksDone.IServices;

namespace VanriseTasksDone
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();

            // Register your services and dependencies
            container.RegisterType<IDeviceService, DeviceService>(new HierarchicalLifetimeManager());

            // Set the dependency resolver to use Unity
            config.DependencyResolver = new UnityDependencyResolver(container);
            // Configure JSON formatting
            config.Formatters.JsonFormatter.SerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(), // Use camelCase for JSON property names
                NullValueHandling = NullValueHandling.Ignore // Ignore null values in JSON
            };

            config.Formatters.Remove(config.Formatters.XmlFormatter);

            // Replace the default controller activator with Unity's controller activator
         //   config.Services.Replace(typeof(IHttpControllerActivator), new UnityHttpControllerActivator(container));

            config.MapHttpAttributeRoutes();

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
