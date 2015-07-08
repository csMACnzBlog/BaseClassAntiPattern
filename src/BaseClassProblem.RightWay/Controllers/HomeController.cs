using System.Web.Mvc;
using BaseClassProblem.BusinessLayer;
using BaseClassProblem.RightWay.Attributes;

namespace BaseClassProblem.RightWay.Controllers
{
    [CustomAuthorize]
    [HandleErrors]
    public class HomeController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;
        private readonly ICustomerService _customerService;
        private readonly ICatalogueService _catalogueService;

        public HomeController(
            IShoppingCartService shoppingCartService,
            ICustomerService customerService,
            ICatalogueService catalogueService)
        {
            _shoppingCartService = shoppingCartService;
            _customerService = customerService;
            _catalogueService = catalogueService;
        }

        public ActionResult Index()
        {
            _catalogueService.GetTopItems();
            _customerService.GetCustomerDashboardDisplay();
            _shoppingCartService.GetCartItemCount();
            return View();
        }
    }
}