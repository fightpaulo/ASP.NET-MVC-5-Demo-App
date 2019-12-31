using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace CadeMeuMedico.Models.Repository
{
    public class UsuarioRepository
    {
        public static bool AutenticaUsuario(string login, string senha)
        {
            try
            {
                using (CadeMeuMedicoDBEntities db = new CadeMeuMedicoDBEntities())
                {
                    Usuario usuario = db.Usuario
                        .Where(u => u.Login.Equals(login) && u.Senha.Equals(senha))
                        .SingleOrDefault();
                    
                    if (usuario == null)
                    {
                        return false;
                    }
                    else
                    {
                        CookieRepository.RegistraCookieAutenticacao(usuario.IDUsuario);
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public static Usuario RecuperaUsuarioPorID(long id)
        {
            Usuario usuario = null;
            try
            {
                using (CadeMeuMedicoDBEntities db = new CadeMeuMedicoDBEntities())
                {
                    usuario = db.Usuario.Where(u => u.IDUsuario == id).SingleOrDefault();
                }
            }
            catch (Exception)
            {

                return null;
            }

            return usuario;
        }

        public static Usuario VerificaSeOUsuarioEstaLogado()
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies["UserCookieAuthentication"];

            if (cookie == null)
            {
                return null;
            }

            long idUsuario = Convert.ToInt64(cookie.Values["IDUsuario"]);

            Usuario usuario = RecuperaUsuarioPorID(idUsuario);

            return usuario;
        }
    }
}