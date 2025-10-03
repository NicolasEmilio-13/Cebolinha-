
Console.Clear();
string fraseDigitada, fraseComDislalia;
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Write("Digite uma frase: ");
fraseDigitada = Console.ReadLine()!;
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
fraseComDislalia = fraseDigitada
.Replace("r", "l")
.Replace("R", "L");
Console.WriteLine(fraseComDislalia);
Console.ResetColor();