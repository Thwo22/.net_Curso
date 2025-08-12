using models;

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;

bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É Possível realizar essa venda?{possivelVenda}");

if (possivelVenda)
{
    Console.WriteLine("Venda Realizada");
}
else
{
    Console.WriteLine("Desculpe. Não temos essa quantidade em estoque.");
}




// string a = "15-";

// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão feita com sucesso");

// double a = 4 / 2 + 2;

// Console.WriteLine(a);

// int a = 5;
// double b = a;

// Console.WriteLine(b);

// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);

// int a = 10;
// int b = 20;

// int c = a + b;

// Console.WriteLine(c);

// DateTime dataAtual = DateTime.Now.AddHours(5);
// Console.WriteLine(dataAtual);

// string apresentado = "olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.90M;

// bool condicao = true;

// Console.WriteLine(apresentado);
// Console.WriteLine("Valor da variavel é:" + quantidade);
// Console.WriteLine("Valor da variavel Altura é:" + altura.ToString("0.00"));
// Console.WriteLine("Valor da variavel é Preço:" + preco);
// Console.WriteLine("Valor da variavel é condição:" + condicao);


/*Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Thiago";
pessoa1.Idade = 18;
pessoa1.Apresentar();*/

