using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int x, int y);
        int Subtrair(int x, int y);
        int Multiplicar(int x, int y);
        int Dividir(int x, int y);
        
    }
}