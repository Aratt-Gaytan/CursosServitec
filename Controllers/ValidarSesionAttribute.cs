using System;
using System.Web;
using System.Web.Mvc;

namespace CursosServitec.Controllers
{
    public class ValidarSesionAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            if (HttpContext.Current.Session["usuario"] == null)
            {
                filterContext.Result = new RedirectResult("~/Acceso/Login");
            }

            base.OnActionExecuting(filterContext);
        }
    }
}