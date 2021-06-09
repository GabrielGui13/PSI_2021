using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcModel.Models;

namespace MvcModel.Controllers
{
    public class CategoriaController : Controller
    {
        private static List<Categoria> categorias = new List<Categoria>() {
            new Categoria() { CategoriaID = 1, nome = "Notebooks"},
            new Categoria() { CategoriaID = 2, nome = "Monitores"},
            new Categoria() { CategoriaID = 3, nome = "Impressoras"},
            new Categoria() { CategoriaID = 4, nome = "Mouses"},
            new Categoria() { CategoriaID = 5, nome = "Desktops"}
        };
        //GET: Categorias
        public IActionResult Index()
        {
            return View(categorias);
        }
    }
}
