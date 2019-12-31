using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadeMeuMedico.Models.Repository
{
    public class CookieRepository
    {
        public static void RegistraCookieAutenticacao(long idUsuario)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies["UserCookieAuthentication"];

            if (cookie == null)
            {
                cookie = new HttpCookie("UserCookieAuthentication");
                cookie.Values.Add("IDUsuario", idUsuario.ToString());
                cookie.HttpOnly = true;
                cookie.Expires = DateTime.Now.AddDays(365);
                HttpContext.Current.Response.AppendCookie(cookie);
            }
        }
    }
}