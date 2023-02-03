// See https://aka.ms/new-console-template for more information
double num3 = 18.65;
string txt = Console.ReadLine();
int num1 = Int32.Parse(txt);
string txt2 = Console.ReadLine();
int num2 = Int32.Parse(txt);
Console.WriteLine("VALOR ABSOLUTO: " + Math.Abs(num1));
Console.WriteLine("POTENCIA: " + Math.Pow(num1, 3));
Console.WriteLine("RAIZ CUADRADA: " + Math.Sqrt(num1));
Console.WriteLine("SENO: " + Math.Sin(num1));
Console.WriteLine("COSENO: " + Math.Cos(num1));
Console.WriteLine("EL MÁXIMO ES: " + Math.Max(num1, num2));
Console.WriteLine("EL MÍNIMO ES: " + Math.Min(num1, num2));
Console.WriteLine("LA PARTE ENTERA ES: " + Math.Truncate(num3));
Console.WriteLine("REDONDEO: " + Math.Round(num3));



