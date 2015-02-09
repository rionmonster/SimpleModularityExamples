using System;
using System.Configuration;
using System.Web.Mvc;

namespace SimpleModularity.Areas.Red
{
    public class RedAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Red";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            // Determine if it is enabled or not
            Application.ModulesEnabled.Add(AreaName, Convert.ToBoolean(ConfigurationManager.AppSettings[AreaName]));

            // Read from your configuration to determine if routes should be established
            if (Application.ModulesEnabled[AreaName])
            {
                context.MapRoute(
                    AreaName,
                    String.Format("Parent/{0}/{{action}}/{{id}}", AreaName),
                    new { controller = AreaName, action = "Index", id = UrlParameter.Optional }
                );
            }
        }
    }
}