using Fiap.Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new ContaCorrente()
            {
                Agencia = 0,
                Numero = 2,
                DataAbertura = DateTime.Now,
                Saldo = 2000,
                Tipo = TipoConta.Comum
            };

            var cp = new ContaPoupanca(0.6m)
            {
                Agencia = 1,
                Numero = 2,
                Saldo = 1000,
                Taxa = 2,
                DataAbertura = new DateTime(2018, 4, 5)
            };

            try
            {
                cc.Retirar(100);
                Console.WriteLine(cc.Saldo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
