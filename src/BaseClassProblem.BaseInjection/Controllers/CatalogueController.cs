using System.Web.Mvc;
using BaseClassProblem.BusinessLayer;

namespace BaseClassProblem.BaseInjection.Controllers
{
    public class CatalogueController : ControllerBase
    {
        public CatalogueController(
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

        // GET: Catalogue
        public ActionResult Index()
        {
            CatalogueService.GetCatalogues();
            return View();
        }
    }
}