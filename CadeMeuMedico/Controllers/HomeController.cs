using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class HomeController : BaseController
    {
        private CadeMeuMedicoDBEntities db = new CadeMeuMedicoDBEntities();

        public ActionResult Index()
        {
            List<BannersPublicitarios> banners = db.BannersPublicitarios
                .OrderByDescending(b => b.IDBanner).Take(2).ToList();

            return View(banners);
        }

        public ActionResult Login()
        {
            ViewBag.Title = "Seja bem-vindo(a)";

            return View();
        }
    }
}