using System.Web.Mvc;

namespace BaseClassProblem.ServiceLocation.Controllers
{
    public class CatalogueController : ControllerBase
    {
        // GET: Catalogue
        public ActionResult Index()
        {
            CatalogueService.GetCatalogues();
            return View();
        }
    }
}