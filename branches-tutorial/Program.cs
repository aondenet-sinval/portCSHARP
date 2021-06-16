using System;
//Desafio: Encontrar a soma de todos os inteiros de 1 a 20 divisiveis por 3
ChallengeAnswer();
void ChallengeAnswer()
{
    int sum = 0;
    for (int number = 1; number < 21; number++)
    {
        if (number % 3 == 0)
        {
            sum = sum + number;
        }
    }
    Console.WriteLine($"The sum is {sum}");
}

/*
ExplorerLoops();
void ExplorerLoops()
{
for (char col = 'a'; col < 'd'; col++)
{
    //Console.WriteLine($"Col is: {col}");
    for (int row = 1; row < 4; row++)
    {
        Console.WriteLine($"What is row is: {col}, {row}");
    }
}
}
*/
/*
//Loop com for
for (int counter = 0; counter < 10; counter = counter++)
//Ou para incrementar de 3 em 3 abaixo
//for (int counter = 0; counter < 10; counter = counter + 3)
{
    Console.WriteLine($"Saida: {counter}");
}
*/
/*
//Loop While com do
int counter = 0;
do 
{
    Console.WriteLine($"Valor correto é: {counter}");
    counter = counter + 3;
}while (counter < 8);
*/
/*
EnquantoIssoForAssim();
void EnquantoIssoForAssim()
{
    int contar = 0;
    while (contar < 8)
    {
i        Console.WriteLine($"Contar: {contar}");
        contar = contar + 3;
    }
}
*/
