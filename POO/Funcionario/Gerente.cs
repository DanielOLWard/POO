﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Funcionario
{
    class Gerente : Funcionario
    {
        public void Bonificar()
        {
            _salario = _salario * 1.10;
        }
    }
}
