using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.ContasBancarias
{
    class ContaCorrente : ContaBancaria
    {
        public void CobrarTaxa(double taxa)
        {
            _saldo -= taxa;
        }
    }
}
