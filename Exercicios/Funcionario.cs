using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Funcionario
    {
        private double _salario;

        public void SetSalario(double salario)
        {
            _salario = salario;
        }

        public double GetSalario()
        {
            return _salario;
        }
    }
}
