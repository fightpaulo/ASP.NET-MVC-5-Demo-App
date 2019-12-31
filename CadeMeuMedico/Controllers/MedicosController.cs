using CadeMeuMedico.Filters;
using CadeMeuMedico.Models;
using CadeMeuMedico.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class MedicosController : BaseController
    {
        private CadeMeuMedicoDBEntities db = new CadeMeuMedicoDBEntities();

        public ActionResult Index()
        {
            MedicoViewModel medicoViewModel = new MedicoViewModel();

            List<Medico> medicos = db.Medico.Include("Cidade")
                .Include("Especialidade").ToList();

            medicoViewModel.Medicos = medicos;
            medicoViewModel.TextoPesquisaMedico = string.Empty;

            return View(medicoViewModel);
        }

        [HttpPost]
        public ActionResult Index(MedicoViewModel medicoViewModel)
        {
            List<Medico> medicos = db.Medico.Include("Cidade")
                .Include("Especialidade")
                .Where(m => m.Nome.ToUpper().Contains(medicoViewModel.TextoPesquisaMedico.ToUpper()))
                .ToList();

            medicoViewModel.Medicos = medicos;

            return View(medicoViewModel);
        }

        public ActionResult Adicionar()
        {
            ViewBag.IDCidade = new SelectList(db.Cidade, "IDCidade", "Nome");
            ViewBag.IDEspecialidade = new SelectList(db.Especialidade, "IDEspecialidade", "Nome");

            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Medico medico)
        {
            if (ModelState.IsValid)
            {
                db.Medico.Add(medico);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            // Se não der certo, eu preciso construir o form de novo.
            // Por isso, passo os valores ao ViewBag para poder usá-los na View
            ViewBag.IDCidade = new SelectList(db.Cidade, "IDCidade", "Nome");
            ViewBag.IDEspecialidade = new SelectList(db.Especialidade, "IDEspecialidade", "Nome");

            return View();
        }

        public ActionResult Editar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Medico medico = db.Medico.Find(id);

            if (medico == null)
            {
                return HttpNotFound();
            }

            ViewBag.IDCidade = new SelectList(db.Cidade, "IDCidade", "Nome", medico.IDCidade);
            ViewBag.IDEspecialidade = new SelectList(db.Especialidade, "IDEspecialidade", "Nome", medico.IDEspecialidade);

            return View(medico);
        }

        [HttpPost]
        public ActionResult Editar(Medico medico)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medico).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.IDCidade = new SelectList(db.Cidade, "IDCidade", "Nome", medico.IDCidade);
            ViewBag.IDEspecialidade = new SelectList(db.Especialidade, "IDEspecialidade", "Nome", medico.IDEspecialidade);

            return View(medico);
        }

        public ActionResult Excluir(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Medico medico = db.Medico.Find(id);

            if (medico == null)
            {
                return HttpNotFound();
            }

            db.Medico.Remove(medico);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Detalhes(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Medico medico = db.Medico.Find(id);

            if (medico == null)
            {
                return HttpNotFound();
            }

            return View(medico);
        }
        
        public ActionResult Fechar()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Limpar()
        {
            return RedirectToAction("Index");
        }
    }
}