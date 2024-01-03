
using NI365078_MVC5_L1.Filter;
using System.Web.Mvc;
 

namespace NI365078_MVC5_L1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new TimeTrackerFilter());
             
        }
    }
}
