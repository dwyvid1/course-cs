Console.WriteLine("Saida de dados : Formatação ");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.Write(nome);
Console.Write(idade);
Console.WriteLine();

// Escrever na mesma linhha 'Maria tem 25 anos'
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.Write(" anos");
Console.WriteLine();
Console.WriteLine("-------concatenação---------");

// Usar a concatenação : usando o perador +
Console.WriteLine(nome + " tem " + idade + " anos ");
Console.Write(nome + " tem " + idade + " anos ");
Console.WriteLine();
Console.WriteLine("-------interpolação--------");

// Usar a interpolação de strings : $ -> a interpolação {}
Console.WriteLine($"{nome} tem {idade} anos");
Console.WriteLine();
Console.WriteLine("-------placeholders--------");

// Usar placeholders : usando o operador {} com numeração com inicio em zero
Console.WriteLine("{0} tem {1} anos", nome, idade);

Console.ReadLine();