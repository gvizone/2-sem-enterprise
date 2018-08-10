using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.Console.UI.Model
{
    class Veiculo
    {
        private double _potencia;

        public int Ano { get; set; }
        public double Potencia
        {
            get { return _potencia; }
            set
            {
                if(value >=0)
                {
                    _potencia = value;
                }
            }
        }
    }
}
