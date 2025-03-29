using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Contas
{
    class ContaPoupanca : ContaBancaria
    {
        public void RenderJuros()
        {
            _saldo = (5 * _saldo) / 100;
        }
    }
}
