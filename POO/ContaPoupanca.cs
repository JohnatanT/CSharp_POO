using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class ContaPoupanca
    {
        private int agencia;
        private int numeroConta;
        private decimal saldo;
        private decimal taxaMovimento;

        /* Encapsulamento */

        //Agenica
        public int Agencia {
            get { return agencia; }
            set {
                if(value > 0)
                {
                    agencia = value;
                }
            }
        }
        //Numero da Conta
        public int NumeroConta {
            get { return numeroConta; }
            set {
                if(value > 0)
                {
                    numeroConta = value;
                }               
            }
        }
        //Saldo
        public decimal Saldo {
            get { return saldo; }
            set { saldo = value; }
        }
        //Taxa de Movimento
        public decimal TaxaMovimento {
            get { return taxaMovimento; }
            set { taxaMovimento = value; }
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
