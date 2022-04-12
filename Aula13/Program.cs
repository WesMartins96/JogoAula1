using System;

namespace Aula13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comandos condicionais
            // if - SE   (o mais lembrado)

            double media = 9;
            if (media < 4)
            {
                Console.WriteLine("Reprovado");
            }
            else if (media < 6)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Aprovado");
            }

            //operador ternario
            //condição ? RespostaVerdadeira  : RespostaFalsa



            //numero randomico
            //Criando um objeto(instânciando)
            int input = new Random().Next(-5, 5);
            
            if (input >= 0)
            {
                Console.WriteLine("Positivo: " + input);
            }
            else
            {
                Console.WriteLine("Negativo: " + input);
            }

            //o sistema vai pedir ao usuario que digite um numero entre 1 e 5
            // caso acerte parabens vc acertou, senão errooooooouuuuu

            int input2 = new Random().Next(1, 5);

            Console.WriteLine("Tente descobri o numero que eu pensei [de 1 a 5]");
            int chute = int.Parse(Console.ReadLine());
            if(input2 == chute)
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
