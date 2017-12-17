using System;

namespace POO
{
    public class Relatorio
    {
        private decimal saldoGeral;

        public decimal SaldoGeral { get { return saldoGeral; } private set { saldoGeral = value; } }

        public void Somar(Conta conta)
        {
            this.saldoGeral += conta.Saldo;
        }

       
    }
}
