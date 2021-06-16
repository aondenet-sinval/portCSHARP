using System;
OperDecimais();
void OperDecimais()
{
    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;
    Console.WriteLine($"Decimal máximo é: {max} mínimo é: {min}");
    //Conferir precisão com tipos decimais
    decimal a = 1.0m / 3.0m;
    double b = 1.0 / 3.0;
    Console.WriteLine($"Decimal recebe {a}. Double recebe: {b}");
    //Cálculo da área proposto 2.50 ^ 2 * PI
    decimal quad = 2.50m * 2.50m;
    decimal area = quad * 3.14m; 
    Console.WriteLine($"A area com raio de 2.50 é: {area}");
}
/*
WorkWithDoubles();
void WorkWithDoubles()
{
    double a = 1101202303404505606707808909.27;
    double expre = a * 4.11 / 4.11;
    Console.WriteLine($"Expre é igual a {a}. Mas o retorno foi: {expre}");
}
*/
/*
TestLimits();
void TestLimits()
{
    double a = 19.4;
    double b = 23;
    double c = 8;
    double d = (a + b) / c;
    Console.WriteLine(d);
    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"Double máximo: {max} e mínimo: {min}");
}
*/
/*
OperacoesMatematicas();//invocando o método
void OperacoesMatematicas()//Declarando e definindo o método
{
    int a = 20;
    int b = 12;
    int c = a + b;
    int d = a + b * c;
    int e = d / a;

    Console.WriteLine(c);
    // subtraction
    c = a - b;
    Console.WriteLine("C é igual a: " + c);
    // multiplication
    c = a * b;
    Console.WriteLine("C é igual a: " + c);
    // division
    c = a / b;
    Console.WriteLine("C é igual a: " + c);
    //Multiplas operações:
    Console.WriteLine("D é igual a: " + d);
    Console.WriteLine("E é igual a: " + e);
}
*/
/*
OrdemPrecedencia();
void OrdemPrecedencia()
{
    int a = 20;
    int b = 12;
    int c = a + b;
    int d = a + b * c;
    int e = d / a;
    //Alterando a ordem das operações
    int f = 2 ^ 3;
    int g = c + d * a + 128 * 6;
    Console.WriteLine("F é igual a: " + f);
    Console.WriteLine("G é igual a: " + g);
    int h = (c + d) / (a + 128) * 6;//A variavel h refere-se a f alterado a ordem de exxecução
    int i = (c + d) * (a + 128) * 6;//A variável i refere-se a g alterada a ordem de execução
    Console.WriteLine("Alterando a ordem, F é igual a: " + h);
    Console.WriteLine("Alterando a ordem, G é igual a: " + i);
    //Usando módulo para aumentar a precisão das operações
    int resto = d % a;
    Console.WriteLine("O resto da divisão de d / a é: " + resto);
    int min = int.MinValue;
    int max = int.MaxValue;
    Console.WriteLine($"O valor máximo de um interiro é {max} e o valor mínimo é: {min}");
    int estouroMais = max / 2 * 3;
    Console.WriteLine($"Estouro de valor máximo de inteiro: {estouroMais}");
}
*/