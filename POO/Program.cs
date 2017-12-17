using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objeto Conta Corrente
            ContaCorrente cc = new ContaCorrente();
            Console.WriteLine(cc.TaxaMovimento);
            Console.WriteLine(cc.Limite);

            //Obejto Conta Poupança
            ContaPoupanca cp = new ContaPoupanca();
            Console.WriteLine(cp.Limite);
           

            Console.ReadLine();
        }
    }
}
