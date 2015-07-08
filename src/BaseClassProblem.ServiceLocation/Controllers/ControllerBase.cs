using System.Web.Mvc;
using System.Web.Mvc.Filters;
using BaseClassProblem.BusinessLayer;
using BaseClassProblem.ServiceLocation.IOC;

namespace BaseClassProblem.ServiceLocation.Controllers
{
    public class ControllerBase : Controller
    {
        protected IAuthenticationService AuthenticationService
        {
            get { return Service.Locate<IAuthenticationService>(); }
        }

        protected ICatalogueService CatalogueService
        {
            get { return Service.Locate<ICatalogueService>(); }
        }

        protected ICustomerService CustomerService
        {
            get { return Service.Locate<ICustomerService>(); }
        }

        protected ILoggingService LoggingService
        {
            get { return Service.Locate<ILoggingService>(); }
        }

        protected IMetricsService MetricsService
        {
            get { return Service.Locate<IMetricsService>(); }
        }

        protected IOrderService OrderService
        {
            get { return Service.Locate<IOrderService>(); }
        }

        protected IShoppingCartService ShoppingCartService
        {
            get { return Service.Locate<IShoppingCartService>(); }
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LoggingService.Log("Action Executing");
            base.OnActionExecuting(filterContext);
        }

        protected override void OnAuthentication(AuthenticationContext filterContext)
        {
            AuthenticationService.Authenticate();
            base.OnAuthentication(filterContext);
        }
    }
}