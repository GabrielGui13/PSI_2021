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

        public IActionResult Index() {
            return View(categorias);
        }
        public IActionResult Create() {
            return View();
        }
        [HttpPost] //Recebe os valores pelo método POST
        [ValidateAntiForgeryToken] //ativa a validação @Html.AntiForgeryToken();
        public ActionResult Create(Categoria categoria) {
            categorias.Add(categoria); //adiciona nova categoria na "database"
            categoria.CategoriaId = categorias.Select(m => m.CategoriaId).Max() + 1; 
            //A sintaxe apresentada consulta o maior código de categoria (CategoriaId) existente na lista
            return RedirectToAction("Index"); //redireciona para o Index
        }
        public ActionResult Edit(long id) {
            return View(categorias.Where(m => m.CategoriaId == id).First()); //Filter em js, retorna o primeiro valor dentro das condicoes
        }
        //O método deve remover o elemento original da lista e substituir pelo objeto Categoria editado recebido da visão. Após editar, vai para a visão da lista.
        [HttpPost] 
        [ValidateAntiForgeryToken] 
        public ActionResult Edit(Categoria categoria) {
            categorias.Remove(categorias.Where(c => c.CategoriaId == categoria.CategoriaId).First());
            categorias.Add(categoria);
            return RedirectToAction("Index"); 
        }
        public ActionResult Details(long id) {
            return View(categorias.Where(m => m.CategoriaId == id).First());
        }
        public ActionResult Delete(long id) {
            return View(categorias.Where(m => m.CategoriaId == id).First());
        }
        [HttpPost] 
        [ValidateAntiForgeryToken] 
        public ActionResult Delete(Categoria categoria) {
            categorias.Remove(categorias.Where(c => c.CategoriaId == categoria.CategoriaId).First());
            return RedirectToAction("Index"); 
        }
    }
}
