using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Carros
{
    class CarroEletrico : Carro
    {
        public int bateria;
        public int tempoDeCarga;

        // override ira sobrescrever o codigo virtual
        public override void MostrarInformacoes()
        {
            // base - classe pai
            base.MostrarInformacoes();
            Console.WriteLine("Bateria: " + bateria);
            Console.WriteLine("Tempo de Carga: " + tempoDeCarga);
        }
    }
}
