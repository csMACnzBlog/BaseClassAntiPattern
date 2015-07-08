using System.Web.Mvc;
using System.Web.Mvc.Filters;
using BaseClassProblem.BusinessLayer;

namespace BaseClassProblem.BaseInjection.Controllers
{
    public class ControllerBase : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;
        private readonly IOrderService _orderService;
        private readonly IMetricsService _metricsService;
        private readonly ILoggingService _loggingService;
        private readonly ICustomerService _customerService;
        private readonly ICatalogueService _catalogueService;
        private readonly IAuthenticationService _authenticationService;

        public ControllerBase(
            IShoppingCartService shoppingCartService,
            IOrderService orderService,
            IMetricsService metricsService,
            ILoggingService loggingService,
            ICustomerService customerService,
            ICatalogueService catalogueService,
            IAuthenticationService authenticationService)
        {
            _shoppingCartService = shoppingCartService;
            _orderService = orderService;
            _metricsService = metricsService;
            _loggingService = loggingService;
            _customerService = customerService;
            _catalogueService = catalogueService;
            _authenticationService = authenticationService;
        }

        protected IAuthenticationService AuthenticationService
        {
            get { return _authenticationService; }
        }

        protected ICatalogueService CatalogueService
        {
            get { return _catalogueService; }
        }

        protected ICustomerService CustomerService
        {
            get { return _customerService; }
        }

        protected ILoggingService LoggingService
        {
            get { return _loggingService; }
        }

        protected IMetricsService MetricsService
        {
            get { return _metricsService; }
        }

        protected IOrderService OrderService
        {
            get { return _orderService; }
        }

        protected IShoppingCartService ShoppingCartService
        {
            get { return _shoppingCartService; }
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