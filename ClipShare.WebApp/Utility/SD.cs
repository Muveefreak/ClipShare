using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ClipShare.WebApp.Utility
{
    public static class SD
    {
        public static string IsActive(this IHtmlHelper html, string controller, string action, string cssClass = "active")
        {
            var routeData = html.ViewContext.RouteData;
            var currentController = routeData.Values["controller"]?.ToString();
            var currentAction = routeData.Values["action"]?.ToString();
            if (string.Equals(currentController, controller, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(currentAction, action, StringComparison.OrdinalIgnoreCase))
            {
                return cssClass;
            }
            return string.Empty;
        }
    }
}
