using System.Web.Mvc;
using BaseClassProblem.BusinessLayer;
using BaseClassProblem.RightWay.Attributes;

namespace BaseClassProblem.RightWay.Controllers
{
    [CustomAuthorize]
    [HandleErrors]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // GET: Order
        public ActionResult Index()
        {
            _orderService.GetOrders();
            return View();
        }
    }
}