using System;

namespace JogoAula1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input2 = new Random().Next(1, 5);
            char resp = 's';
            while (resp == 's')
            
                
                Console.WriteLine("não saiu...");
                Console.WriteLine("Continuar? [S/N]?");
                resp = char.Parse(Console.ReadLine());

           
            Console.WriteLine("Tente descobri o numero que eu pensei [de 1 a 5]");
            int chute = int.Parse(Console.ReadLine());
            if (input2 == chute)
            {
                Console.WriteLine($"Pensei em: {chute}");
                Console.WriteLine("Parabens");
            }
            else
            {
                Console.WriteLine($"Não foi dessa vez, eu pensei em {chute}");
                Console.WriteLine("Errrrroooooooooouuuu");
            }

        }
    }
}
