using System;

namespace Aula11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variaveis de Memoria
            //tipo nome = valor;
            string nome = "Wesley";
            int idade = 25;
            double salario = 8500.65;
            decimal saldo = 68000.759m;
            float nota = 4.5f;
            char genero = 'M';

            Console.WriteLine("____________________________________");

            Console.WriteLine("Concatenação");
            Console.WriteLine("Nome: " + nome + "  tem: " + idade + "Anos");
            Console.WriteLine("salário: " + saldo.ToString("F2"));

            Console.WriteLine("____________________________________");

            Console.WriteLine("Placeholder");
            Console.WriteLine("Nome: {0} tem: {1} anos e saldo de {2:F2}", nome, idade, saldo);

            Console.WriteLine("____________________________________");

            Console.WriteLine("Interpolação");
            Console.WriteLine($"Nome: {nome} Idade: {idade}  Saldo: {saldo}");

            
        }
    }
}
