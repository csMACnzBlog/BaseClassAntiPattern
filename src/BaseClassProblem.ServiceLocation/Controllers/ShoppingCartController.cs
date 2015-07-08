using System.Web.Mvc;

namespace BaseClassProblem.ServiceLocation.Controllers
{
    public class ShoppingCartController : ControllerBase
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            ShoppingCartService.GetCartItems();
            return View();
        }
    }
}