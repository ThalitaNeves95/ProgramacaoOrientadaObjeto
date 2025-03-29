using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO;

namespace Exercicios
{
    class Gerente : Funcionario
    {
        public double Bonificar()
        {
            _salario *= 1.10;
            return _salario;
        }
    }
}
