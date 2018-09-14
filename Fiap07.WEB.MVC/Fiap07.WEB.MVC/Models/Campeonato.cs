using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Models
{
    public class Campeonato
    {
        public int CampeonatoId { get; set; }
        public string Nome { get; set; }
        public decimal Premio { get; set; }

        //Relacionamentos
        public virtual IList<Time> Times { get; set; }
    }
}