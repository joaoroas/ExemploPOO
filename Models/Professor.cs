using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public sealed class Professor : Pessoa
    {
        public Professor()
        {
            
        }
        public Professor(string nome) : base(nome)
        {
        }

        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Eu sou o Professor {Nome} e ganho {Salario.ToString("C")} reais.");
        }
    }
}