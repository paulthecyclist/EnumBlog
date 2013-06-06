using System.Web.Mvc;
using log4net;

namespace EnumBlog.MVC.Filters
{
    public class ExceptionLoggingFilter : IExceptionFilter
    {
        private readonly ILog _logger;

        public ExceptionLoggingFilter(ILog logger)
        {
            _logger = logger;
        }

        public virtual void OnException(ExceptionContext filterContext)
        {
            _logger.Error(filterContext.Exception);
        }

        public interface IExceptionFilter
        {          
            void OnException(ExceptionContext filterContext);
        }
    }
}