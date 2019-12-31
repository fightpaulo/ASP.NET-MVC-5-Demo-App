using CadeMeuMedico.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class UsuariosController : Controller
    {
        public ActionResult AutenticacaoDeUsuario(string login, string senha)
        {
            if (UsuarioRepository.AutenticaUsuario(login, senha))
            {
                return Json(new
                {
                    OK = true,
                    Mensagem = "Usuário autenticado com sucesso. Redirecionando..."
                },
                JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new
                {
                    OK = false,
                    Mensagem = "Usuário não encontrado. Tente novamente."
                },
                JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Sair()
        {
            HttpCookieCollection cookies = HttpContext.Request.Cookies;

            if (cookies != null)
            {
                HttpContext.Response.Cookies["UserCookieAuthentication"].Expires = DateTime.Now.AddDays(-1);
            }

            return RedirectToAction("Login", "Home");
        }
    }
}