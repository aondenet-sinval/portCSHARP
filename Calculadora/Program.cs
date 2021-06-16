using System;

namespace Calculadora
{
    class Program
    {
        enum Menu {Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair};

        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {
            Console.WriteLine("Seja bem vindo à  Calculadora, selecione uma das opções:");
            Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Potenciação\n6 - Radiciação\n7 - Sair");

            Menu opcao = (Menu)int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case Menu.Soma:
                Some();
                break;
                //------------------
                case Menu.Subtracao:
                Subtraia();
                break;
                //------------------
                case Menu.Divisao:
                Divida();
                break;
                //------------------
                case Menu.Multiplicacao:
                Multiplique();
                break;
                //------------------
                case Menu.Potencia:
                Potencialize();
                break;
                //------------------
                case Menu.Raiz:
                Radicialize();
                break;
                //------------------

                case Menu.Sair:
                escolheuSair = true;
                break;
            }
            Console.Clear();
            
            }        
        }
        static void Some()
        {
            Console.WriteLine("Você escolheu efetuar a soma de dois números:");
            Console.WriteLine("Escreva o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine($"A soma dos números é: {resultado}");
            Console.WriteLine($"Aperte Enter para voltar ao Menu Inicial");
            Console.ReadLine();
        }
        static void Subtraia()
        {
            Console.WriteLine("Você escolheu efetuar a subtração de dois números:");
            Console.WriteLine("Escreva o primeiro número:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine($"A subtração dos números é: {resultado}");
            Console.WriteLine($"Aperte Enter para voltar ao Menu Inicial");
            Console.ReadLine();
        }
        static void Divida()
        {
            Console.WriteLine("Você escolheu efetuar a divisão de dois números:");
            Console.WriteLine("Escreva o primeiro número:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número:");
            float b = float.Parse(Console.ReadLine());
            float resultado = a / b;
            Console.WriteLine($"A divisão dos números é: {resultado}");
            Console.WriteLine($"Aperte Enter para voltar ao Menu Inicial");
            Console.ReadLine();
        }
                static void Multiplique()
        {
            Console.WriteLine("Você escolheu efetuar a multiplicação de dois números:");
            Console.WriteLine("Escreva o primeiro número:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo número:");
            float b = float.Parse(Console.ReadLine());
            float resultado = a * b;
            Console.WriteLine($"A multiplicação dos números é: {resultado}");
            Console.WriteLine($"Aperte Enter para voltar ao Menu Inicial");
            Console.ReadLine();
        }
        
        static void Potencialize()
        {
            Console.WriteLine("Você escolheu efetuar a potenciação de dois números:");
            Console.WriteLine("Escreva a base:");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o expoente:");
            float e = float.Parse(Console.ReadLine());
            float resultado = (float)Math.Pow(b,e);
            Console.WriteLine($"A potenciação dos números é: {resultado}");
            Console.WriteLine($"Aperte Enter para voltar ao Menu Inicial");
            Console.ReadLine();
        }
        static void Radicialize()
        {
            Console.WriteLine("Você escolheu ver a raíz quadrada:");
            Console.WriteLine("Escreva o número para ver a raíz quadrada :");
            float a = float.Parse(Console.ReadLine());
            float resultado = (float)Math.Sqrt(a);//Square Root ou raíz quadrada
            Console.WriteLine($"A raíz de {a} é: {resultado}");
            Console.WriteLine($"Aperte Enter para voltar ao Menu Inicial");
            Console.ReadLine();
        }          
    }
}
