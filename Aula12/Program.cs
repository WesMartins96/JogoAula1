using System;

namespace Aula12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.Write("Escreva uma frase: ");
            string frase = Console.ReadLine();
            Console.WriteLine($"você digitou: {frase}");

            Console.WriteLine("__________________");

            Console.Write("Entre com um numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou o numero: {numero}");

            Console.WriteLine("__________________");*/

            Console.Write("Digite a primeira Nota: ");
            double notaOne = double.Parse(Console.ReadLine());

            Console.Write("Digite a Segunda Nota: ");
            double notaTwo = double.Parse(Console.ReadLine());

            Console.Write("Digite a Terceira Nota: ");
            double notaTree = double.Parse(Console.ReadLine());

            Console.Write("Digite a Quarta Nota: ");
            double notaFour = double.Parse(Console.ReadLine());

            Console.WriteLine($"A MÉDIA DAS NOTAS É: {(notaOne + notaTwo + notaTree + notaFour) / 4}");


        }
    }
}
