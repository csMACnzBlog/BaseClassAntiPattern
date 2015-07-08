using System.Web.Mvc;
using BaseClassProblem.BusinessLayer;
using BaseClassProblem.RightWay.IOC;

namespace BaseClassProblem.RightWay.Attributes
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            Service.Locate<IAuthenticationService>().Authenticate();
            base.OnAuthorization(filterContext);
        }
    }
}