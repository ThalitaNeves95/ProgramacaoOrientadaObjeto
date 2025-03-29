using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ContasBancarias
{
    class ContaBancaria
    {
        protected double _saldo = 0;

        public void Depositar(double entrada)
        {
            _saldo += entrada;
        }

        public void Sacar(double saida)
        {
            _saldo -= saida;
        }

        public double VerSaldo()
        {
            return _saldo;
        }

    }
}
