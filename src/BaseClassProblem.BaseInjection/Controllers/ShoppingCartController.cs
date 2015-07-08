using System.Web.Mvc;
using BaseClassProblem.BusinessLayer;

namespace BaseClassProblem.BaseInjection.Controllers
{
    public class ShoppingCartController : ControllerBase
    {
        public ShoppingCartController(
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

        // GET: ShoppingCart
        public ActionResult Index()
        {
            ShoppingCartService.GetCartItems();
            return View();
        }
    }
}