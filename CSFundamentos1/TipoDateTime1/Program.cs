Console.WriteLine("## Stuct DateTime ##\n");

DateTime hoje = DateTime.Now;
Console.WriteLine($"hoje : {hoje}\n");

// Extrair informações da data atual

// Console.WriteLine(hoje.Year);
// Console.WriteLine(hoje.Month);
// Console.WriteLine(hoje.Day);
// Console.WriteLine(hoje.Hour);
// Console.WriteLine(hoje.Minute);
// Console.WriteLine(hoje.Second);
// Console.WriteLine(hoje.Millisecond);

// Adicionando valores
// Console.WriteLine(hoje.AddDays(30));
// Console.WriteLine(hoje.AddMonths(1));
// Console.WriteLine(hoje.AddHours(2));
// Console.WriteLine(hoje.AddYears(5));

// Obter o dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

// Data no formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());

Console.ReadKey();