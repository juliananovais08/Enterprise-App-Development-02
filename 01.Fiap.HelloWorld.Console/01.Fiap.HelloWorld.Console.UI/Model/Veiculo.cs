using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.Console.UI.Model
{

    //Classe abstrata:não pode ser instanciada
    //e pode conter métodos abstratos
    abstract class Veiculo
    {
        //Atributos
        private double _potencia;

        //Gets e Sets

        public int Ano { get; set; }

        public double Potencia
        {
            get { return _potencia; }
            set
            {

                if (value >= 0)
                {
                    _potencia = value;
                }
                _potencia = value;
            }
        }

        //Construtor
        public Veiculo(int ano, double potencia)
        {
            Ano = ano;
            potencia = Potencia;
        }

        //Métodos
        //virtual permite a sobreescrita de método
        public virtual void Acelerar()
        {
            System.Console.WriteLine("Veiculo acelerando");
        }

        public abstract void Desligar();


    }
}
