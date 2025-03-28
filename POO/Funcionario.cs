using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Funcionario
    {
        private double _salario;

        public double SetSalario()
        {
            Console.Write("Digite o valor que o funcionario ira receber esse mes: ");
            double salario = double.Parse(Console.ReadLine());
            return _salario += salario;
        }

        public double GetSalario()
        {
            Console.WriteLine($"O salario do funcionario esse mes sera R${_salario}");
            return _salario;
        }
    }
}
