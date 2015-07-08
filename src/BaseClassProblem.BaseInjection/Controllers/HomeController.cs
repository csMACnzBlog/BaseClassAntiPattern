using System.Web.Mvc;
using BaseClassProblem.BusinessLayer;

namespace BaseClassProblem.BaseInjection.Controllers
{
    public class HomeController : ControllerBase
    {
        public HomeController(
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

        public ActionResult Index()
        {
            CatalogueService.GetTopItems();
            CustomerService.GetCustomerDashboardDisplay();
            ShoppingCartService.GetCartItemCount();
            return View();
        }
    }
}