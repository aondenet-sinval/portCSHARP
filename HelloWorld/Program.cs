using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HelloWorld
{
    class Program
    {//Pausa no vídeo: 4:12; foreach 4:39

        enum Cores { Branco = 1, Verde = 2, Chocolate = 3, Marron = 4}
        enum Opcao {Criar = 1, Deletar, Editar, Listar, Atualizar }

        static void Main(string[] args)
        {
            string[] forteste = {"Amor", "Alegria","Paz", "Autodominio", "Bondade", "Paciência", "Fé"};

            for (int s = 6; s > -1; s--)
            {
                Console.Write(s + " - ");
                Console.WriteLine(forteste[s]);
            }

            /*
            //Trabalhando com foreach
            string[] frutas = {"Abacaxi", "Uva", "Maçã", "Melancia", "Banana", "Jaca"};
            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);//imprimindo todos os itens do array frutas              
            }
            */
            /*
            //Criação de menus de opçoes
            Console.WriteLine("Digite uma das opções:");
            Console.WriteLine("1 - Criar\n2 - Deletar\n3 - Editar\n4 - Listar\n5 - Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelect = (Opcao)index;
            Console.WriteLine(opcaoSelect);
            switch (opcaoSelect)
            {
                case Opcao.Criar:
                Console.WriteLine($"Você escolheu {opcaoSelect}");
                break;
                case Opcao.Deletar:
                Console.WriteLine($"Você escolheu {opcaoSelect}");
                break;
                case Opcao.Editar:
                Console.WriteLine($"Você escolheu {opcaoSelect}");
                break;
                case Opcao.Listar:
                Console.WriteLine($"Você escolheu {opcaoSelect}");
                break;
                case Opcao.Atualizar:
                Console.WriteLine($"Você escolheu {opcaoSelect}");
                break;
                default:
                Console.WriteLine($"O número {index} não faz parte das opções. Escolha uma das opções de 1 - 5");
                break;
            }
            */
            //Cores Teste = Cores.Chocolate;
            //Console.WriteLine((Cores)2);
            
            /*            
            Console.WriteLine("Digite uma cor");
            string cor = Console.ReadLine();
            switch (cor){
                case "vermelho": 
                Console.WriteLine($"Sua cor favorita é vermelho");
                break;
                case "amarelo":
                Console.WriteLine("Sua cor favorita é amarelo");
                break;
                case "azul":
                Console.WriteLine("Sua cor favorita é azul");
                break;
                default:
                Console.WriteLine("Digite uma das seguintes cores: vermelho amarelo ou azul");
                break;

                */
                Console.ReadLine();
                
            
            /*
            //Trabalhando com array pausa do vídeo em 3:44:
            //Declarando array
            string[] Produtos = new string[10]{
                "Memória ram 2 gb",//0
                "Teclado HP",//1
                "Mouse sem fio HP",//2
                "SSD 550TB",//3
                "Processador Quad Core",//4
                "Codigo: 0101 ",//5
                "Codigo: 0102 ",//6
                "Codigo: 0103 ",//7
                "Codigo: 0104 ",//8
                "Codigo: 0105 "//9
            };
            Console.Write(Produtos[5]);
            Console.WriteLine(Produtos[0]);
            //Dclaração de arraay simplificada:
            string[] Sucos = {"Suco de maçã", 
            "Suco de uva", 
            "Suco de melão", 
            "Suco de limão", 
            "Suco de maracuja"};
            Console.WriteLine(Sucos[1]);
            */
            //video 3:48
            /*
            //Inserindo porcentagem 30% 180.45
            decimal valorBase = 1800.4m;//Valor base do produto
            decimal porcDesconto = 10m;
            //Chamando a função de porcentagem
            decimal porcTar = Porcentagem(porcDesconto, valorBase);
            Console.WriteLine($"O resultado da porcentagem passada é: R$ {porcTar}.");
            //Chamando a função de desconto e subtraindo o desconto dado ao cliente
            decimal valorComDesc = ValorComDesconto(valorBase, porcTar);
            Console.WriteLine($"O valor total com deconto de {porcDesconto}% é: R$ {valorComDesc}.");
            //Console.WriteLine("Escreva um nome de algum cliente." );
            //string novoCliente = Console.ReadLine();
            */
            /*
            Produtos("Memoria ram 2 gb R$ ", 33.50, " Compra por: Sinval Gomes dos Santos.");
            Produtos("Memoria ram 2 gb R$ ", 33.50, " Compra por: Ana Araújo.");
            Console.WriteLine("Digite na sequencia os valores um, dois e três");
            int valorUm = Math.Abs(int.Parse(Console.ReadLine()));
            int valorDois = int.Parse(Console.ReadLine());
            int valorTresPass = int.Parse(Console.ReadLine());
            int valorTres = Math.Abs(valorTresPass);
            int soma = SomandoTdo(valorUm, valorDois, valorTres);

            Console.WriteLine($"A soma dos valores passados é igual a: {soma}" );
            Console.ReadLine();
            */
            //if (valorUm < 0)
            //int valorUm = Math.Abs(valorUmPass);
            //if (valorDois < 0)
            //int valorDois = Math.Abs(valorDoisPass);
            //if (valorTres < 0)
           
            //MensagemPositiva();
            //MensagemPositiva();
            /*
            //PRATICANDO 240 EXERCÍCIOS C#
            //Calculando a area de um cilindro
            // O volume do cilindro é igual a altura multiplicada por pi multiplicado pelo quadrado do raio => altura * (pi * (raio * raio))
            //Suposição cilindro com altura= 2m; raio 0,30m
            decimal pi = 3.1415m; 
            decimal altura = 2m;
            decimal raioAl = 0.80m;
            decimal areaCil =  pi * (raioAl * raioAl);
            decimal volumeCil = altura * areaCil;
            Console.WriteLine($"O volume do cilindro é igual a {volumeCil}.");
            */
        }
        /*
        static void Produtos(string nome, double preco, string cliente)
        {
            Console.WriteLine(nome + preco + cliente);
        }
        static int SomandoTdo(int a, int b, int c)
        {
            int somaFinal = a + b + c;
            return somaFinal;
        }
        static decimal Porcentagem(decimal a, decimal b)
        {
            decimal c = 100m;
            decimal retornarPorcentagem = a * b / c;
            return retornarPorcentagem;
        }
        static decimal ValorComDesconto(decimal a, decimal b)
        {
            decimal ValorDesconto = a - b;
            return ValorDesconto;
        }
        */
            /*
            //Operdores lógicos na prática
            Console.WriteLine("Qual sua idade?");
            //Para que não de erro é precsoconverter string em int usando
            //o método Parse que faz a conversão como abaixo.
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sua idade é {idade}");
            //Criança maior ouigual a 11 anos
            //Adolescente de 12 a 17 anos
            //Adulto 19 a 60
            //quasse idoso 60 a 70
            //Idoso acima de 71 anos
            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine($"Vocẽ é uma criança.");
            }
            else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine($"Você é adolescente.");
            }
            else if (idade >= 19 && idade <= 60)
            {
                Console.WriteLine($"Você é um adulto.");
            }
            else if (idade >= 56 && idade <= 70)
            {
                Console.WriteLine($"Você é quase idoso");
            }
            else if (idade > 70)
            {
                Console.WriteLine($"Você já é idoso");
            }
            else
            {
                Console.WriteLine($"O progrma foi encerrado porque você não digitou sua idade. \nTente novamente!!!");
            }
            Console.ReadLine();
*/
            /*
            //Opearadores lógicos && (significa E) e || (significa OU)
                  //Trabalhando com if else if
            int a = 10;
            int b = 20;
            int c = 3;
            string sim = "Correto ";
            string maior = "é maior que";
            string menor = "é menor que";
            string nao = "Incorreto.";
             if (a < b && c > b)
             {
                 Console.WriteLine($"{sim} {a} {maior} {b}.");                 
             }
             else if (a < b)
             {
                 Console.WriteLine($"{sim} {a} {menor} {b}");               
             }
             else if (a > c)
             {
                 Console.WriteLine($"{sim} {a} {maior} {c}");
             }
             else
             {
                 Console.WriteLine(nao);
             }
             */
            /*
            //Trabalhando com if else if
            int a = 80;
            int b = 20;
            int c = 3;
            string sim = "Correto ";
            string maior = "é maior que";
            string menor = "é menor que";
            string nao = "Incorreto";
             if (a > b)
             {
                 Console.WriteLine($"{sim} {a} {maior} {b}.");                 
             }
             else if (a < b)
             {
                 Console.WriteLine($"{sim} {a} {menor} {b}");               
             }
             else if (a > c)
             {
                 Console.WriteLine($"{sim} {a} {maior} {c}");
             }
             else
             {
                 Console.WriteLine(nao);
             }
            
            //Operadores
            int resSoma = 3+2;
            int resSub = 5 -2;
            int resMult = 3 * 9;
            float resDiv = 40f / 3;

while (resMult < 35)

{ 
    resMult++;
    int ressoma = resMult + resMult;
    Console.WriteLine(resMult); 
    Console.WriteLine(ressoma);    
    }

            Console.WriteLine("Soma é: " + resSoma + "\nDivisão é: " + resDiv + "\nSubtração é: " + resSub + "\nMultiplicação é: " + resMult);
            
            string nome = "";
            Console.WriteLine("Escreva seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine($"O nome é {nome}");

           Console.ReadLine();
            */        
            
            
                   /*
            int segundaGuerraMundial = 1939;
            decimal velocidadMedF1 = 294.49m;
            //bool segundaGuerraMundial = true;
            Console.WriteLine(segundaGuerraMundial);
            Console.WriteLine(velocidadMedF1);

            const string novato = "Roberto";
            Console.WriteLine(novato);
            novato = "Rebeca";
            Console.WriteLine(novato);
*/
       /* 
        static void MensagemPositiva()
        {
            Console.WriteLine("Muito bom");
            Console.WriteLine("Você foi bem sucedido!!!");
            Console.WriteLine("O programa ficou show de bola");
        }
        */
    }
}
