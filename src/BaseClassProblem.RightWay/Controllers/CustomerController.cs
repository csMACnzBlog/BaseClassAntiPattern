using System.Web.Mvc;
using BaseClassProblem.BusinessLayer;
using BaseClassProblem.RightWay.Attributes;

namespace BaseClassProblem.RightWay.Controllers
{
    [CustomAuthorize]
    [HandleErrors]
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: Customer
        public ActionResult Index()
        {
            _customerService.GetCustomerDetails();
            return View();
        }
    }
}