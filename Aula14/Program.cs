using System;

namespace Aula14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //laço de repetição     WHILE  / for / foreach / do

            /*int i = 0;
            while(i<=10)
            {
                Console.WriteLine(i);
                //incremento
                i++;
            }*/

            char resp = 's';
            while (resp == 's')
            {
                Console.WriteLine("não saiu...");
                Console.WriteLine("Continuar? [S/N]?");
                resp = char.Parse(Console.ReadLine());                                
            }


        }
    }
}
