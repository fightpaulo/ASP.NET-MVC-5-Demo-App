using CadeMeuMedico.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class CidadesController : BaseController
    {
        private CadeMeuMedicoDBEntities db = new CadeMeuMedicoDBEntities();

        // GET: Cidades
        public ActionResult Index()
        {
            List<Cidade> cidades = db.Cidade.ToList();

            return View(cidades);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                db.Cidade.Add(cidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cidade cidade = db.Cidade.Find(id);

            if (cidade == null)
            {
                return HttpNotFound();
            }

            return View(cidade);
        }

        [HttpPost]
        public ActionResult Editar(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cidade).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(cidade);
        }

        public ActionResult Excluir(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cidade cidade = db.Cidade.Find(id);

            if (cidade == null)
            {
                return HttpNotFound();
            }

            db.Cidade.Remove(cidade);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Cidade cidade = db.Cidade.Find(id);

            if (cidade == null)
            {
                return HttpNotFound();
            }

            return View(cidade);
        }
    }
}