using System;
using System.Collections.Generic;
using System.Diagnostics;
 
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace NI365078_MVC5_L1.Filter
{
    public class TimeTrackerFilter : ActionFilterAttribute
    {
        private Stopwatch stopWatch = new Stopwatch();
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Trace.Write("(Logging Filter)Action Executing: " +
                filterContext.ActionDescriptor.ActionName);
            stopWatch.Reset();
            stopWatch.Start();
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            stopWatch.Stop();
            

            TimeSpan timeSpan = stopWatch.Elapsed;

            string executionTimed= string.Format("Time: {0}h {1}m {2}s {3}ms", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
            
            filterContext.HttpContext.Items["executionTime"] = executionTimed;
            string actionName =  filterContext.RouteData.Values["action"].ToString();
            string controllerName = filterContext.RouteData.Values["controller"].ToString();
            filterContext.HttpContext.Items["actionName"] = actionName;
            filterContext.HttpContext.Items["controllerName"] = controllerName;
            if (filterContext.Exception != null)
                filterContext.HttpContext.Trace.Write("(Logging Filter)Exception thrown");

            base.OnActionExecuted(filterContext);
        }
        
    }
    public class DontTrackTheTimeAttribute : FilterAttribute, IOverrideFilter
    {
        public Type FiltersToOverride
        {
            get
            {
                return typeof(IActionFilter);
            }
        }
    }
}

