using System.Threading.Channels;

Console.WriteLine("\n ## Entrada de Dados");

Console.WriteLine("\nInforme o seu nome");
string nome = Console.ReadLine();

Console.WriteLine("\nInforme a sua idade");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nO seu nome é {nome}");
Console.WriteLine($"\ne você tem {idade} anos");

Console.ReadKey();