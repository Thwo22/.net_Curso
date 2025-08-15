using System.Diagnostics;
using ExemploFundamentos.Commom.models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("MG");
listaString.Add("BH");

Console.WriteLine("Percorrendo a lista com FOR");
for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição Nº{contador} - {listaString[contador]}");
}

Console.WriteLine("Percorrendo a lista com FOREACH");
int contadorForeach = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
    contadorForeach++;
}




























// int[] arrayInteiros = new int[4];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 22;
// arrayInteiros[2] = 33;
// arrayInteiros[3] = 44;

// int[] arraysInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arraysInteirosDobrados, arrayInteiros.Length);



// Console.WriteLine("Percorrendo array com for");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     Console.WriteLine($"Posição Nº {contador} é: {arrayInteiros[contador]}");
// }
// Console.WriteLine(arraysInteirosDobrados);
























// Console.WriteLine("Percorrendo array com foreach");
// foreach (int valores in arrayInteiros)
// {
//     Console.WriteLine(valores);
// }








// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Thiago";
// pessoa1.Idade = 18;
// pessoa1.Apresentar();

// string opcao;
// bool exibir = true;
// while (exibir)
// {
//     Console.Clear();
//     Console.WriteLine("Digite sua opção:");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar Cliente:");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de Cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar Cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibir = false;
//             break;

//         default:
//             Console.WriteLine("Opção Inválida");
//             break;
//     }

//     Console.WriteLine("O Programa Se Encerrou");
//     }


















// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($" {contador}* Execução: {numero} x {contador} = {numero * contador}");
//     contador++;
// }



// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }



































// Calculadora calc = new Calculadora();
// calc.RaizQuadrada(10);

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Divisao(2, 2);
// calc.Potencia(3, 3);

// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("pode ir pedalar");
// }
// else
// {
//     Console.WriteLine("Não pode ir pedalar");
// }
// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o 10");
// numero++;

// Console.WriteLine(numero);