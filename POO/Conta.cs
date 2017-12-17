﻿using System;

namespace POO
{
    public class Conta
    {
        private int agencia;
        private int numeroConta;
        private decimal saldo;
        private decimal limite;


        //Construtor
        public Conta()
        {
            this.limite = 1000;
        }

        public Conta(decimal limite)
        {
            this.limite = limite;
        }

        /* Encapsulmanento */

        //Limite
        public decimal Limite {
            get { return limite; }
           private set { limite = value; }
        }

        //Agencia
        public int Agencia
        {
            private set
            {
                if (value > 0)
                {
                    agencia = value;
                }

            }
            get { return agencia; }
        }
        //Numero da Conta
        public int NumeroConta
        {
            private set
            {
                if (value > 0)
                {
                    numeroConta = value;
                }

            }
            get { return numeroConta; }
        }
        //Saldo
        public decimal Saldo
        {
            private set { saldo = value; }
            get { return saldo; }
        }

        /* Métodos */

        //Função de Sacar
        public virtual void Sacar(decimal valor)
        {
            this.saldo = this.saldo - valor;
        }

        //Função de Depositar
        public void Depositar(decimal valor)
        {
            this.saldo = this.saldo + valor;
        }
    }
}
