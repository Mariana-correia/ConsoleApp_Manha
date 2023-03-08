// See https://aka.ms/new-console-template for more information
using ConsoleApp_Manhã;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, "Mouse sem fio", 56.90M);
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());