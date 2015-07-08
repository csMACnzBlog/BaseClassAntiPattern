using System.Web.Mvc;
using BaseClassProblem.BusinessLayer;
using BaseClassProblem.RightWay.IOC;

namespace BaseClassProblem.RightWay.Attributes
{
    public class HandleErrorsAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Service.Locate<ILoggingService>().Log("Action Executing");
            base.OnActionExecuting(filterContext);
        }
    }
}