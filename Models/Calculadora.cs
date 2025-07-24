using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculadoraC_.Interfaces;

namespace CalculadoraC_.Models
{
    public class Calculadora : ICalculadora
    {
        public string Somar(double num1, double num2)
        {
            return $"O resultado da operação é {num1 + num2}";
        }
        public string Subtrair(double num1, double num2)
        {
            return $"O resultado da operação é {num1 - num2:F2}";
        }
        public string Multiplicar(double num1, double num2)
        {
            return $"O resultado da operação é {num1 * num2:F2}";
        }
        public string Dividir(double num1, double num2)
        {
            return $"O resultado da operação é {num1 / num2:F2}";
        }

        public void MostrarResultado(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}