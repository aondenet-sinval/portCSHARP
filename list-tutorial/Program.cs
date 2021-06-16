using System;
using System.Collections.Generic;
var fibonacciNumbers = new List<int> {1,1};
var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
fibonacciNumbers.Add(previous + previous2);
foreach (var item in fibonacciNumbers)
Console.WriteLine(item);
Console.WriteLine(previous);
Console.WriteLine(previous2);
/*
var names = new List<string> { "Sinval", "Ana", "Felipe", "Joana", "André Felipe" };
names.Add("Maria");
names.Add("Rosa");
names.Add("Paulo Ricardo");
names.Remove("André Felipe");
foreach (var name in names)
{
Console.WriteLine($"Hello {name.ToUpper()}!");
}
//Verificando quantas pessoas fazem parte da lista names
Console.WriteLine($"Meu nome é {names[0]}.");
Console.WriteLine($"The list has {names.Count} people in it");
var local = names.IndexOf("Rosa Clara");
Console.WriteLine($"O nome Rosa está na posição {local} da lista.");
names.Sort();
foreach (var name1 in names)
{
Console.WriteLine(name1);
}
*/