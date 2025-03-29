using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Retangulo
    {
        private double _largura;
        private double _altura;

        public void SetLargura(double largura)
        {
            _largura += largura;
        }

        public void SetAltura(double altura)
        {
            _altura += altura;
        }

        public double GetLargura()
        {
            return _largura;
        }

        public double GetAltura()
        {
            return _altura;
        }

        public double CalcularArea()
        {
            return _altura *= _largura;
        }
    }
}
