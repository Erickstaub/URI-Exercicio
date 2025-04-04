string n1 = Console.ReadLine();
double n2 = double.Parse(Console.ReadLine());
double n3 = double.Parse(Console.ReadLine());
double final = (n2 + (n3 * 0.15));
Console.WriteLine("TOTAL = R$ " + final.ToString("F2"));