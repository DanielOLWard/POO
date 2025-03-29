using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Contas
{
    class ContaCorrente : ContaBancaria
    {
        public void CobraTaxa()
        {
            _saldo -= 10.0;
          
        }
    }
}
