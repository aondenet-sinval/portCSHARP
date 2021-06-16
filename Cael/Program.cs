using System;

namespace Cael
{
    class Program
    {
        static void Main(string[] args)
        { //Calculando a soma de números menor que 1000
        int num, soma;
            soma = 0;
            Console.WriteLine($"Insira um numero inteiro");
            num = int.Parse(Console.ReadLine());
            for (int cont = 0; cont < 1000; cont++)
            {
                if (soma <= 1000)
                {
                    soma = soma + num;
                    Console.WriteLine($"Numeros {num} e {soma}");
                    num = num + 1;
                }
            }
           
        }
    }
}
