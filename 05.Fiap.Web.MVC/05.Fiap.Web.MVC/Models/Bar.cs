using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _05.Fiap.Web.MVC.Models
{
    public class Bar
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Proibido { get; set; }
        public List<string> Cidade { get; set; }
    }
}