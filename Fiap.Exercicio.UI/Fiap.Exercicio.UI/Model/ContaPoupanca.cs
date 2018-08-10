using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInventimento
    {

        //propriedades
        public decimal Taxa { get; set; }

        public decimal Rendimento
        {
            get { return _rendimento; }
        }

        //Campo, Fields (atributos)
        private readonly decimal _rendimento;

        //Construtor
        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if(Saldo < valor)
            {
                throw new Exception("Saldo insuficiente");
            }
            Saldo -= valor + Taxa;
        }
    }
}
