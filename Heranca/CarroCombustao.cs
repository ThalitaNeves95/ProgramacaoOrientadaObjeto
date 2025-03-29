using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class CarroCombustao : Carro
    {
        public string combustivel;
        public override void MostrarInformacoes()
        {
            Console.WriteLine("Modelo:" + modelo);
            Console.WriteLine("Marca:" + marca);
            Console.WriteLine("Quilometragem:" + quilometragem);
            Console.WriteLine("O combustivel é:" + combustivel);
        }
    }
}
