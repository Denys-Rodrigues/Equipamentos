﻿using Equipamentos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Equipamentos.Controllers
{
    public class CategoriasController : Controller
    {
        private static IList<Categoria> categorias = new List<Categoria>()
        {
            new Categoria()
            {
                CategoriaID = 1,
                Nome = "Notebooks"
            },

            new Categoria()
            {
                CategoriaID = 2,
                Nome = "Monitores"
            },

            new Categoria()
            {
                CategoriaID = 3,
                Nome = "Impressoras"
            }
        };
        // GET: Categorias
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View(categorias);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            categoria.CategoriaID = categorias.Select(m => m.CategoriaID).Max() + 1;
            categorias.Add(categoria);
            return RedirectToAction("Index");
        }
    }
}