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

    public class ValidarSesionAdminAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {

            if (HttpContext.Current.Session["usuario"] != null && (HttpContext.Current.Session["tipoUsuario"].ToString() == "2" || HttpContext.Current.Session["tipoUsuario"].ToString() == "1"))
            {
                base.OnActionExecuting(filterContext);
            }
            filterContext.Result = new RedirectResult("~/Acceso/Restringido");
            
        }
    }
}