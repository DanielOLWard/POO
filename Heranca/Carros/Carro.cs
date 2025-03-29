using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Heranca.Carros
{
    class Carro
    {
        public string modelo;
        public string marca;
        public int quilometragem;

         // Virtual - Esse metodo pode ser sobrescrito
        public virtual void MostrarInformacoes()
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Quilometragem: " + quilometragem);
        }
        // Um metodo com o mesmo nome pode receber parametros diferentes
        public virtual void MostrarInformacoes(string nome)
        {
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Quilometragem: " + quilometragem);
            Console.WriteLine("Nome: " + nome);
        }
    }
}
