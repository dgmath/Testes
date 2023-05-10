// Criar a lista de objetos(produtos)

using ListaObjetos;

List<Produto> produtos = new List<Produto>();

produtos.Add( 
    new Produto(2563,"camiseta QuickSilver",19.90f)
);
produtos.Add( 
    new Produto(1025,"tenis Naiki",50f)
);

Produto calcaDiesel = new Produto(1526,"calca Diesel", 15f);
produtos.Add(calcaDiesel);

Console.WriteLine($"Lista Antiga");

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:c2}, Indice: {produtos.IndexOf(item)}");
    
}

Produto produtoBuscado = produtos.Find(x => x.Codigo == 2563);

int index = produtos.IndexOf(produtoBuscado);

produtoBuscado.Preco = 199.90f;

produtos.RemoveAt(index);

produtos.Insert(index,produtoBuscado);

Console.WriteLine($"Lista Atualizada");
foreach (var item in produtos)
{
   Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:c2}, Indice: {produtos.IndexOf(item)}");
}
