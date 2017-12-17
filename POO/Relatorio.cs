using System;

namespace POO
{
    public class Relatorio
    {
        private decimal saldoGeral;
        private decimal tributoGeral;


        public decimal TributoGeral { get { return tributoGeral; } private set { tributoGeral = value; } }
        public decimal SaldoGeral { get { return saldoGeral; } private set { saldoGeral = value; } }

        public void Somar(Conta conta)
        {
            this.saldoGeral += conta.Saldo;
        }

        public void SomarTributos(ITributo conta)
        {
            this.tributoGeral = conta.CalcularTributo();
        }

       
    }
}
