// See https://aka.ms/new-console-template for more information
using ConsoleApp_Manhã;

Console.WriteLine("Hello, World!");

Produto p1 = new Produto(1, "Mouse sem fio", 56.90M);
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

p1.setValor(69.90M);                //para setar o valor, ele cria um novo
p1.setDescricao("Mouse Gamer Razor");
Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

//Pessoa p1 = new Pessoa(1, "Mariana Alvez Correia", "997780181");
//Console.WriteLine("Nome: " + p1.getNome() + " Telefone: " + p1.getTelefone());