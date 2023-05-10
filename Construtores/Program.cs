using Construtores;
// p.Codigo = "1234";
// Console.WriteLine($"{p.Codigo}");

Produto p1 = new Produto();
Produto p2 = new Produto("vivi");
Produto p3 = new Produto("1234","Vivi",1000000f);

Console.WriteLine($"Informe o Codigo");
p1.Codigo = Console.ReadLine()!;
Console.WriteLine($"Informe o Nome");
p1.Nome = Console.ReadLine()!;
Console.WriteLine($"Informe o Preço");
p1.Preco = float.Parse(Console.ReadLine()!);


