using System.Web.Mvc;

namespace BaseClassProblem.ServiceLocation.Controllers
{
    public class HomeController : ControllerBase
    {
        public ActionResult Index()
        {
            CatalogueService.GetTopItems();
            CustomerService.GetCustomerDashboardDisplay();
            ShoppingCartService.GetCartItemCount();
            return View();
        }
    }
}