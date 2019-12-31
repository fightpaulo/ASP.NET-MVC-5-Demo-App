using CadeMeuMedico.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Filters
{
    [HandleError]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method,
        Inherited = true,
        AllowMultiple = true)]
    public class AutorizacaoDeAcesso : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string controller = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string action = filterContext.ActionDescriptor.ActionName;

            if (controller != "Home" && action != "Login")
            {
                if (UsuarioRepository.VerificaSeOUsuarioEstaLogado() == null)
                {
                    filterContext.RequestContext.HttpContext.Response
                        .Redirect("/Home/Login", false);
                }
            }
        }
    }
}