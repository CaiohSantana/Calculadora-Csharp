using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraC_.Interfaces
{
    public interface ICalculadora
    {
        string Somar(double num1, double num2);
        string Subtrair(double num1, double num2);
        string Multiplicar(double num1, double num2);
        string Dividir(double num1, double num2);
    }
}