using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class ContaBancaria
    {
        private double _saldo;
        public double Depositar()
        {
            Console.Write("Digite o valor a ser depositado: ");
            double valor = double.Parse(Console.ReadLine());
            return _saldo += valor;
        }

        public double Sacar()
        {
            Console.Write("Digite o valor a ser sacado: ");
            double valor = double.Parse(Console.ReadLine());
            return _saldo -= valor;
        }

        public double VerSaldo()
        {
            Console.WriteLine($"O seu saldo e R${_saldo}");
            return _saldo;
        }
    }
}
