using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    internal class CarroManual : ICarro
    {
        public void TrocarMarcha()
        {
            Console.WriteLine("Carro Manual Trocando a Marcha!");
        }
    }
}
