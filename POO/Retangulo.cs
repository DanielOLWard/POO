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

        public double SetLargura(double valor)
        {
            return _largura += valor;
        }
        public double GetLargura()
        {
            return _largura;
        }
        public double SetAltura(double valor)
        {
            return _altura += valor;
        }
        public double GetAltura()
        {
            return _altura;
        }
        public double CalcularArea()
        {
            return _largura * _altura;
        }
    }
}
