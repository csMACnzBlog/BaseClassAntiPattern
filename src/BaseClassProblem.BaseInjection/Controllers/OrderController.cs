using System.Web.Mvc;
using BaseClassProblem.BusinessLayer;

namespace BaseClassProblem.BaseInjection.Controllers
{
    public class OrderController : ControllerBase
    {
        public OrderController(
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

        // GET: Order
        public ActionResult Index()
        {
            OrderService.GetOrders();
            return View();
        }
    }
}