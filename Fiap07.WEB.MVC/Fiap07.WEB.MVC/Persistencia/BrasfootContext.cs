using Fiap07.WEB.MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap07.WEB.MVC.Persistencia
{
    public class BrasfootContext : DbContext
    {
        public DbSet<Time> Times { get; set; }
        public DbSet<Campeonato> Campeonatos { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
    }
}