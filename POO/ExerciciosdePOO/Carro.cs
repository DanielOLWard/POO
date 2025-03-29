using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Classe - Definicao (item da vida real representada em codigo)
// Atributos (caracteriscas) - metodos (acoes)

namespace POO.Exercicios
{
    class Carro
    {
        // Atributos
        public string marca;
        public string modelo;
        public int anoFabricacao;

        // Metodos
        public void Andar()
        {
            Console.WriteLine("Carro esta andando!");
        }
        public void Parar()
        {
            Console.WriteLine("Carro esta parando!");
        }
        public void MostrarInformacoes()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Ano de fabricacao: {anoFabricacao}");
        }
    }
}
