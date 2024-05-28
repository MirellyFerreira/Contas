using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro valor: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma operção: +, -, *, / ");
            string operacao = Console.ReadLine();

            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = n1 + n2;
                    break;

                case "-":
                    resultado = n1 - n2;
                    break;

                case "*":
                    resultado = n1 * n2;
                    break;

                case "/":
                    resultado = n1 / n2;
                    break;

             








            }
        }
    }
}
