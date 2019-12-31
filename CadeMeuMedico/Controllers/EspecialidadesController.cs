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
    public class EspecialidadesController : BaseController
    {
        private CadeMeuMedicoDBEntities db = new CadeMeuMedicoDBEntities();

        // GET: Especialidades
        public ActionResult Index()
        {
            List<Especialidade> especialidades = db.Especialidade.ToList();

            return View(especialidades);
        }
        
        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Especialidade especialidade)
        {
            if (ModelState.IsValid)
            {
                db.Especialidade.Add(especialidade);
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

            Especialidade especialidade = db.Especialidade.Find(id);

            if (especialidade == null)
            {
                return HttpNotFound();
            }

            return View(especialidade);
        }

        [HttpPost]
        public ActionResult Editar(Especialidade especialidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(especialidade).State = EntityState.Modified;
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Excluir(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Especialidade especialidade = db.Especialidade.Find(id);

            if (especialidade == null)
            {
                return HttpNotFound();
            }

            db.Especialidade.Remove(especialidade);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Especialidade especialidade = db.Especialidade.Find(id);

            if (especialidade == null)
            {
                return HttpNotFound();
            }

            return View(especialidade);
        }
    }
}