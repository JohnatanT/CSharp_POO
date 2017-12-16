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
