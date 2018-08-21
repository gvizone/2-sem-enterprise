using _05.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05.Fiap.Web.MVC.Controllers
{
    public class BarController : Controller
    {
        private static List<Bar> _bar = new List<Bar>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_bar);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            List<string> cidades = new List<string>
            {
                "São Paulo",
                "Rio de Janeiro",
                "Salvador"
            };
            ViewBag.listaCidade = new SelectList(cidades);
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Bar bar)
        {
            _bar.Add(bar);
            TempData["msg"] = "Bar cadastrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}