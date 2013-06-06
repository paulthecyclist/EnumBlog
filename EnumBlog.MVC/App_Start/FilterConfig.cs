using System.Web.Mvc;
using EnumBlog.MVC.Filters;
using log4net;

namespace EnumBlog.MVC.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters, ILog logger)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ExceptionLoggingFilter(logger));            
        }
    }
}