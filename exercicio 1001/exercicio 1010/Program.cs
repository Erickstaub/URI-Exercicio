string[] linha = Console.ReadLine().Split(' ');

int id1 = int.Parse(linha[0]);
int qnt1 = int.Parse(linha[1]);
decimal money1 = decimal.Parse(linha[2]);

linha = Console.ReadLine().Split(' ');

int id2 = int.Parse(linha[0]);
int qnt2 = int.Parse(linha[1]);
decimal money2 = decimal.Parse(linha[2]);

decimal total = (money1 * qnt1) + (money2 * qnt2);
Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));