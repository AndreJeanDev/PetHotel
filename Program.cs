Console.WriteLine("--- Pet Hotel Check-in ---\n");

Console.Write("Especie......: ");
string especie = Console.ReadLine()!;

Console.Write("Raca.........: ");
string raca = Console.ReadLine()!;

Console.Write("Alcunha......: ");
string alcunha = Console.ReadLine()!;

Console.Write("Idade (anos).: ");
string idade = Console.ReadLine()!;

Console.Write("Pelugem/cor..: ");
string pelagemCor = Console.ReadLine()!;

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("+=========================================================+");
Console.Write("|                 ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Santo Miau Auau");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("                  |");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("+=========================================================+");
Console.Write("| Espécie: ");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write(especie.Trim().ToUpper().PadLeft(15, '.').Substring(0, 15));
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write(" | Raça: ");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write(raca.Trim().ToUpper().PadLeft(22, '.').Substring(0, 22));
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("+=========================================================+");
Console.Write("| Atende pela alcunha de: ");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write(alcunha.Trim().ToUpper().PadLeft(31, '.').Substring(0, 31));
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine(" |");
Console.Write("| Idade: ");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write($"{idade.Trim().ToUpper().PadLeft(2, '0').Substring(0, 2)} ano(s)");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write(" | Pelagem/cor: ");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write(pelagemCor.Trim().ToUpper().PadLeft(23, '.').Substring(0, 23));
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine(" |");

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("+=========================================================+");

Console.ResetColor();