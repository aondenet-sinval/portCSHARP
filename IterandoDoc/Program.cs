using System;

namespace IterandoDoc
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trabalhando com iteração conforme a documentação do C#
            //do e while
            int m = 0;
            int n = 0;
            while (m < 5)
            {
                Console.WriteLine($"Executando a expressão com while: {m}");
                m++;              
            }
            do
            {
                Console.WriteLine($"Executando a expressão com do: {n}");
                n++;
            } while (n < 5);
            for (int i = 10; i > 5; i--)
            {
                Console.WriteLine($"Decrementando: {i}");
            }
            Console.WriteLine("Coffee sizes: 1=Small 2=Medium 3=Large");
            Console.Write("Please enter your selection: ");
            string s = Console.ReadLine();
            int nf = int.Parse(s);
            int cost = 0;
            switch (nf)
            {
                case 1:
                cost += 25;
                break;
                case 2:
                cost += 25;
                goto case 1;
                case 3:
                cost += 50;
                goto case 1;
                default:
                Console.WriteLine("Invalid selection.");
                break;
            }
            if (cost != 0)
            {
                Console.WriteLine($"Please insert {cost} cents.");
            }
            Console.WriteLine("Thank you for your business.");
            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
