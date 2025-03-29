using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicios.ContasBancarias;
using POO;

namespace Exercicios.ContasBancarias
{
    class ContaPoupanca : ContaBancaria
    {
        public double RenderJuros()
        {
            _saldo *= 1.05;
            return _saldo;

        } 
    }
}
