using System.Web.Mvc;

namespace BaseClassProblem.ServiceLocation.Controllers
{
    public class OrderController : ControllerBase
    {
        // GET: Order
        public ActionResult Index()
        {
            OrderService.GetOrders();
            return View();
        }
    }
}