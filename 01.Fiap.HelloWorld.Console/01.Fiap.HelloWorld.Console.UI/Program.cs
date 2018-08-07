using _01.Fiap.HelloWorld.Console.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.Console.UI
{
    class Program
    {

        //Ctrl .

        static void Main(string[] args)
        {
            //Instanciar um carro
            Carro carro = new Carro(2010,2.0);
            carro.Ano = 2010; //set
            carro.ArCondicionado = false;

            System.Console.WriteLine(carro.Ano); //get

            //Instanciar a Lancha
            var lancha = new Lancha(2019,140)
            {
                BoiaSalvavida = true,
                Ano = 2014
            };

        }
    }
}
