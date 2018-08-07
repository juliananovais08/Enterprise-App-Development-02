using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.Console.UI.Model
{
    class Carro : Veiculo

    {

        //Propriedades
        public int Portas { get; set;}
        public bool ArCondicionado { get; set;}
        public TipoCarro Tipo { get; set; }



        //construtor
        public Carro(int ano, double potencia) : base (ano, potencia)
        {

        }

        //Sobrescrever o método
        public override void Desligar()
        {
            System.Console.WriteLine("Virar a chave");
        }

    }
}
