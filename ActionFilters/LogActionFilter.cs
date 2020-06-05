using JamesScioMVC5.HelperUtils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JamesScioMVC5.ActionFilters
{
    public class LogActionFilter : ActionFilterAttribute
    {
        //Called before an Action is Executed by controller
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            this.RouteLog("ActionFilter: OnActionExecuting", filterContext.RouteData);
        }

        //Called after an Action is Executed by controller
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            this.RouteLog("ActionFilter: OnActionExecuting", filterContext.RouteData);
        }

        //Called before a view result is executed by controller
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
            this.RouteLog("ActionFilter: OnActionExecuting", filterContext.RouteData);
        }

        //Called after a view result is executed by controller
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
            this.RouteLog("ActionFilter: OnActionExecuting", filterContext.RouteData);
        }

        public void RouteLog(string LogMessage, RouteData routeData)
        {
            LogMessage += "Method called from controller: " + routeData.Values["controller"] + " and action: " + routeData.Values["action"];
            File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "/Log/Log.txt", "\n\n" + LogMessage);
        }

    }
}