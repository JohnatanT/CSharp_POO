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

            cc.Agencia = 2;
            Console.WriteLine(cc.Agencia);

            Console.ReadLine();
        }
    }
}
