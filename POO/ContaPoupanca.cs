using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca() : base(2000)
        {
                
        }

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor);
        }

        public override void Depositar(decimal valor)
        {
            base.Saldo += valor;
        }

    }
}
