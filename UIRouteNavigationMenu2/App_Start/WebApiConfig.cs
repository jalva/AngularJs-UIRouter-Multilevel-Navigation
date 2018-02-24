using Microsoft.Practices.Unity;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using UINavigation2Controller.Models2;
using UIRouteNavigationMenu2.Models;

namespace UIRouteNavigationMenu2
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            RegisterDependencies(config);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        // Register all dependencies that are to be injected into the web api controller constructors
        private static void RegisterDependencies(HttpConfiguration config)
        {
            var container = new UnityContainer();

            // Register dependencies here
            container.RegisterType<IUiRouterStatesService, UiRouterStatesService>(new HierarchicalLifetimeManager());
            container.RegisterType<INavMenuService, NavMenuService>(new HierarchicalLifetimeManager());

            #region httpConfig.Formatters.JsonFormatter (indented, camel cased, utc date, string enum converter)
            // --- 2) Formatters
            var appXmlType =
                config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);

            var jsonFormatter = config.Formatters.JsonFormatter;
            jsonFormatter.SerializerSettings.Formatting = Newtonsoft.Json.Formatting.Indented;
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            jsonFormatter.SerializerSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat;
            jsonFormatter.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc;

            jsonFormatter.SerializerSettings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());
            // -------------
            #endregion

            config.DependencyResolver = new UnityResolver(container);
        }
    }
}
