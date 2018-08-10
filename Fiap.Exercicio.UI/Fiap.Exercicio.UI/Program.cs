using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instanciar a classe Conta Corrente e Conta poupança

            var cc = new ContaCorrente()
            {
                Agencia = 1,
                Numero = 2,
                Saldo = 10,
                Tipo = Model.TipoConta.Comum,
                DataAbertura = DateTime.Now
            };

            var cp = new ContaPoupanca(0.06m)
            {
                Agencia = 1,
                Numero = 2,
                Saldo = 1000,
                Taxa = 2,
                DataAbertura = new DateTime(2018,1,1)
            };

            try
            {
                cc.Retirar(100);
                Console.WriteLine(cc.Saldo);
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
