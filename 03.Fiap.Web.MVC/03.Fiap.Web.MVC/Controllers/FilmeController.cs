using _03.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _03.Fiap.Web.MVC.Controllers
{
    public class FilmeController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Filme filme)
        {
            ViewBag.titulo = filme.Nome;
            TempData["msg"] = "Filme Cadastrado";
            return View(filme);
            //return Content(filme.Nome);
        }
    }
}