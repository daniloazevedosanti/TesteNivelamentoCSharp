using System;
using System.Globalization;
using System.Xml.Linq;

namespace Questao1
{
    class ContaBancaria {

        public int Numero { get; set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria (int numero, string nome, double saldo)
        {
            Numero = numero;
            NomeTitular = nome;
            Saldo = saldo;
        }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            NomeTitular = nome;
        }

        public void Saque (double quantia)
        {
            if (!(this.Saldo >= quantia))
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }

            this.Saldo -= quantia;
        }

        public void Deposito(double quantia)
        {
            
            this.Saldo += quantia;
        }

        public override string ToString()
        {
            return "Conta " + this.Numero +" , Titular: " + this.NomeTitular + " , Saldo: $ "+this.Saldo ;
        }

    }
}
