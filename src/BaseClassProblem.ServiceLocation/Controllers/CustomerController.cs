using System.Web.Mvc;

namespace BaseClassProblem.ServiceLocation.Controllers
{
    public class CustomerController : ControllerBase
    {
        // GET: Customer
        public ActionResult Index()
        {
            CustomerService.GetCustomerDetails();
            return View();
        }
    }
}