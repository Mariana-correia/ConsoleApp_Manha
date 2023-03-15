// See https://aka.ms/new-console-template for more information
using ConsoleApp_Manhã;

//Console.WriteLine("Hello, World!");

//Produto p1 = new Produto(1, "Mouse sem fio", 56.90M);
//Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

//p1.setValor(69.90M);                //para setar o valor, ele cria um novo
//p1.setDescricao("Mouse Gamer Razor");
//Console.WriteLine(p1.getDescricao() + " " + p1.getValor());

//Pessoa p1 = new Pessoa(1, "Mariana Alvez Correia", "997780181");
//Console.WriteLine("Nome: " + p1.getNome() + " Telefone: " + p1.getTelefone());

Endereco e1 = new Endereco("Grisso Lupi", "134", "15906788", "Conjunto Habitacional Arsenio Micalli", "Taquaritinga", "São Paulo");
Cliente c1 = new Cliente(1, "Mariana", "997780181", e1);
Cliente c2 = new Cliente(2, "Eduardo", "993213904", e1);
Cliente c3 = new Cliente(3, "Monique", "988888888", e1);
Cliente c4 = new Cliente(4, "Rosemeire", "997656514", e1);

Console.WriteLine(c1.getEndereco().getRua());
c1.getEndereco().setRua("Prudente de Morais");
Console.WriteLine(c1.getEndereco().getRua());

Carro car = new Carro();
car.Marca = "VW";
car.numeroPortas = 4;
car.numeroRodas = 4;
car.Cor = "Preto";
car.quantidadeAcento = 5;
car.PagaImposto = true;

Aviao aviao = new Aviao();
aviao.portasInternas = 50;
aviao.numeroPortas = 1;
aviao.numeroRodas = 3;
aviao.Cor = "Branco";
aviao.quantidadeAcento = 500;
aviao.PagaImposto = false;

Bike bicicleta = new Bike();
bicicleta.PagaImposto = false;

Console.WriteLine(c1.getEndereco().getEnderecoCompleto());

Console.WriteLine(aviao.ExibirDados());
Console.WriteLine(car.ExibirDados());

List<Veiculos> listaVeiculos = new List<Veiculos>();
listaVeiculos.Add(aviao);
listaVeiculos.Add(car);
listaVeiculos.Add(bicicleta);

List<Cliente> listaCliente = new List<Cliente>();
listaCliente.Add(c1);
listaCliente.Add(c2);
listaCliente.Add(c3);   
listaCliente.Add(c4);

foreach (Cliente item in listaCliente)
{
    Console.WriteLine(item.getNome());
}