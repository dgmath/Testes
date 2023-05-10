using Atividade_Carro;

List<Carro> carros = new List<Carro>();

for (int i = 0; i < 2; i++)
{
    Carro carro = new Carro();
    Console.WriteLine($"Insira a {i + 1}º Marca do carro que você deseja adicionar: ");
    carro.Marca = Console.ReadLine();
    Console.WriteLine($"Insira qual a {i + 1}º cor do carro:");
    carro.Cor = Console.ReadLine();

    carros.Add(carro);
}


foreach (var item in carros)
{
    Console.WriteLine($@"{carros.IndexOf(item) + 1}º Carro:

    Marca: {item.Marca}
    Cor: {item.Cor}");
    Console.WriteLine();
}
