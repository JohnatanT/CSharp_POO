using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class ContaCorrente : Conta
    {

        private decimal taxaMovimento;

        //Construtor 
        public ContaCorrente() : base(999)
        {
            this.taxaMovimento = 0.1M;
        }


        //Taxa de Movimento
        public decimal TaxaMovimento
        {
            set { taxaMovimento = value; }
            get { return taxaMovimento; }
        }


    }
}
