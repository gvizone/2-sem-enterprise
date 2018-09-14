using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.Controllers
{
    public class TimeController : Controller
    {
        private BrasfootContext _context = new BrasfootContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Time time)
        {
            _context.Times.Add(time);
            _context.SaveChanges();
            TempData["msg"] = "Cadastrado!";
            return RedirectToAction("Cadastrar");
        }
    }
}