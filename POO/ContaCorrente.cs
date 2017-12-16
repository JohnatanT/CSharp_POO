using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class ContaCorrente
    {

        private int agencia;
        private int numeroConta;
        private decimal saldo;
        private decimal taxaMovimento;

        /* Encapsulmanento */

        //Agencia
        public int Agencia{
            set {
                if(value > 0)
                {
                    agencia = value;
                }
                   
            }
            get { return agencia; }
        }
        //Numero da Conta
        public int NumeroConta {
            set {
                if(value > 0)
                {
                    numeroConta = value;
                }
               
            }
            get { return numeroConta; }
        }
        //Saldo
        public decimal Saldo {
            set { saldo = value; }
            get { return saldo; }
        }
        //Taxa de Movimento
        public decimal TaxaMovimento {
            set { taxaMovimento = value; }
            get { return taxaMovimento; }
        }

        /* Métodos */

        //Função de Sacar
        public void Sacar(decimal valor)
        {
            saldo = saldo - valor;
        }

        //Função de Depositar
        public void Depositar(decimal valor)
        {
            saldo = saldo + valor;
        }


    }
}
