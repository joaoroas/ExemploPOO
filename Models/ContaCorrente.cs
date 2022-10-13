using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }

        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if(valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Saque realizado de: R${valor}");
                Console.WriteLine($"Seu saldo é de: R${saldo}");
            }
            else
            {
                Console.WriteLine("Saldo em conta insuficiênte.");
            }
        }
    }
}