using System.Web.Mvc;
using BaseClassProblem.BusinessLayer;

namespace BaseClassProblem.BaseInjection.Controllers
{
    public class CustomerController : ControllerBase
    {
        public CustomerController(
            IShoppingCartService shoppingCartService,
            IOrderService orderService,
            IMetricsService metricsService,
            ILoggingService loggingService,
            ICustomerService customerService,
            ICatalogueService catalogueService,
            IAuthenticationService authenticationService) :
                base(
                shoppingCartService,
                orderService,
                metricsService,
                loggingService,
                customerService,
                catalogueService,
                authenticationService)
        {
        }

        // GET: Customer
        public ActionResult Index()
        {
            CustomerService.GetCustomerDetails();
            return View();
        }
    }
}