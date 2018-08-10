using _01.Fiap.HelloWorld.Console.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Ano = 2010;
            carro.ArCondicionado = false;

            System.Console.WriteLine(carro.Ano);

            var lancha = new Lancha()
            {
                BoiaSalvaVida = true,
                Ano = 1999
            };
        }
    }
}
