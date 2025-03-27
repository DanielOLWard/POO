using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Produto
    {
        public string nome;
        public double preco;
        public int qtdEestoque;
        public double CalcularTotal()
        {
            double calcularTotal = qtdEestoque * preco;
            return calcularTotal;
        }
    }
}
