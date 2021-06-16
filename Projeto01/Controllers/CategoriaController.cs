using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto01.Models;

namespace Projeto01.Controllers
{
    public class CategoriaController : Controller
    {
        private static IList<Categoria> categorias = new List<Categoria>() {
            new Categoria() { CategoriaId = 1, Nome = "Notebooks"},
            new Categoria() { CategoriaId = 2, Nome = "Monitores"},
            new Categoria() { CategoriaId = 3, Nome = "Impressoras"},
            new Categoria() { CategoriaId = 4, Nome = "Mouses"},
            new Categoria() { CategoriaId = 5, Nome = "Desktops"}
        };

        public IActionResult Index()
        {
            return View(categorias);
        }
        public IActionResult Create() {
            return View();
        }
    }
}
