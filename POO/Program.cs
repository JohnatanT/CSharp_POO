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
            cc.Saldo = 1000;
            cc.Sacar(200);
            Console.WriteLine(cc.Saldo);

            //Obejto Conta Poupança
            ContaPoupanca cp = new ContaPoupanca();
            cp.Saldo = 1000;
            cp.Sacar(200);

            Console.WriteLine(cp.Saldo);
           

            Console.ReadLine();
        }
    }
}
