using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _04.Fiap.Web.MVC.Models
{
    public class Medico
    {
        public int Crm { get; set; }
        public String Nome { get; set; }
        public bool Ativo { get; set; }
        public string Descricao { get; set; }
        public decimal Salario { get; set; }
    }
}