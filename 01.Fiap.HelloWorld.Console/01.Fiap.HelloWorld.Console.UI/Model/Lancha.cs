using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.Console.UI.Model
{
    class Lancha : Veiculo, IAquatico

        //Identar Ctrl k d

    {
        //Propriedade
        public bool BoiaSalvavida { get; set; }

        public Lancha(int ano, double potencia) : base (ano, potencia)
        {

        }

        public override void Acelerar()
        {
            System.Console.WriteLine("Empurrar a manete");
        }

        public override void Desligar()
        {
            System.Console.WriteLine("Desligando a lancha");
        }

        public void Flutuar()
        {
            System.Console.WriteLine("Floating");
        }
    }
}
