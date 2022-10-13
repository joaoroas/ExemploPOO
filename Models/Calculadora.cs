using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int x, int y)
        {
            return x / y;
        }

        public int Multiplicar(int x, int y)
        {
            return x * y;
        }

        public int Somar(int x, int y)
        {
            return x + y;
        }

        public int Subtrair(int x, int y)
        {
            return x - y;
        }
    }
}