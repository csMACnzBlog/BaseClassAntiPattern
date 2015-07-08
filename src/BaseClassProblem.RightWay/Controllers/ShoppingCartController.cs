using System.Web.Mvc;
using BaseClassProblem.BusinessLayer;
using BaseClassProblem.RightWay.Attributes;

namespace BaseClassProblem.RightWay.Controllers
{
    [CustomAuthorize]
    [HandleErrors]
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        // GET: ShoppingCart
        public ActionResult Index()
        {
            _shoppingCartService.GetCartItems();
            return View();
        }
    }
}