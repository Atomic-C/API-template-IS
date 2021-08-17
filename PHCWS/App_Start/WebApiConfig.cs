﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApiAuthenticate.Filters;

namespace PHCWS
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
            // Web API configuration and services        

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "PHCAPI",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //config.Filters.Add(new RequireHttpsAtribute());
            config.Filters.Add(new BasicAuthenticationAttribute());
        }
	}
}