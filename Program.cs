using System.Collections;
using System.Diagnostics;
using System.IO.Compression;
using System.Runtime.InteropServices;
using CalculadoraC_.Models;

Calculadora calc = new();
double num2;
string resultado;
string resposta;
string pedirSegundoNumero = "Digite o segundo numero";


do
{

    Console.WriteLine("Bem vindo a calculadora!");
    Console.WriteLine("Digite o primeiro numero");
    double num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Selecione a operação (+, -, *, /)");
    string operacao = Console.ReadLine();



    switch (operacao)
    {
        case "+":
            Console.WriteLine(pedirSegundoNumero);
            num2 = Convert.ToInt32(Console.ReadLine());
            resultado = calc.Somar(num1, num2);
            calc.MostrarResultado(resultado);
            break;

        case "-":
            Console.WriteLine(pedirSegundoNumero);
            num2 = Convert.ToInt32(Console.ReadLine());
            resultado = calc.Subtrair(num1, num2);
            calc.MostrarResultado(resultado);
            break;

        case "*":
            Console.WriteLine(pedirSegundoNumero);
            num2 = Convert.ToInt32(Console.ReadLine());
            resultado = calc.Multiplicar(num1, num2);
            calc.MostrarResultado(resultado);
            break;

        case "/":
            Console.WriteLine(pedirSegundoNumero);
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Não é possivel dividir por zero");
            }
            else
            {
                resultado = calc.Dividir(num1, num2);
                calc.MostrarResultado(resultado);
            }
            break;

        default:
            Console.WriteLine("Operação incorreta");
            break;
    }

    Console.WriteLine("Deseja fazer um novo calculo? (sim/nao)");
    resposta = Console.ReadLine().ToLower();
    Console.Clear();

} while (resposta == "sim");