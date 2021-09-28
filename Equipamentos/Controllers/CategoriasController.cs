using Equipamentos.Context;
using Equipamentos.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Equipamentos.Controllers
{
    public class CategoriasController : Controller
    {
        private EFContext context2 = new EFContext();

        // GET: Categorias
        public ActionResult Index()
        {
            return View(context2.Categorias.OrderBy(c => c.Nome));
        }

        public ActionResult Create()
        {
            return View();
        }

        // Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            context2.Categorias.Add(categoria);
            context2.SaveChanges();
            return RedirectToAction("Index");
        }

        // Edit
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = context2.Categorias.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                context2.Entry(categoria).State = EntityState.Modified;
                context2.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoria);
        }

        // Details
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = context2.Categorias.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        // Delete
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria categoria = context2.Categorias.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            Categoria categoria = context2.Categorias.Find(id);
            context2.Categorias.Remove(categoria);
            context2.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}