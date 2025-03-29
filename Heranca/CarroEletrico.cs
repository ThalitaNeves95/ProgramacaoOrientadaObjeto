using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class CarroEletrico : Carro
    {
        public int bateria;
        public int tempoDeCarga;

        public override void MostrarInformacoes()
        {
            // base - Classe pai
            base.MostrarInformacoes();
            Console.WriteLine("Porcentagem de bateria:" + bateria);
            Console.WriteLine($"O tempo para a recarga é: {tempoDeCarga} horas");
        }
    }
}
