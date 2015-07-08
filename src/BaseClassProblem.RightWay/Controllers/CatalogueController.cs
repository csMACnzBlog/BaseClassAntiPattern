using System.Web.Mvc;
using BaseClassProblem.BusinessLayer;
using BaseClassProblem.RightWay.Attributes;

namespace BaseClassProblem.RightWay.Controllers
{
    [CustomAuthorize]
    [HandleErrors]
    public class CatalogueController : Controller
    {
        private readonly ICatalogueService _catalogueService;

        public CatalogueController(
            ICatalogueService catalogueService)
        {
            _catalogueService = catalogueService;
        }

        // GET: Catalogue
        public ActionResult Index()
        {
            _catalogueService.GetCatalogues();
            return View();
        }
    }
}