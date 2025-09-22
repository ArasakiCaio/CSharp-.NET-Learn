Random dice = new Random();

int d1 = dice.Next(1, 7);
int d2 = dice.Next(1, 7);
int d3 = dice.Next(1, 7);
int sum = d1 + d2 + d3;

Console.WriteLine($"A soma dos dados d1: {d1}, d2: {d2}, d3: {d3} = {sum}");

if ((d1 == d2) || (d1 == d3) || (d2 == d3))
{
    if ((d1 == d2) && (d2 == d3))
    {
        Console.WriteLine("Três dados iguais! Soma 6!");
        sum += 6;
        Console.WriteLine($"Novo valor = {sum}");
    }
    else
    {
        Console.WriteLine("Dois dados iguais! Soma 2!");
        sum += 2;
        Console.WriteLine($"Novo valor = {sum}");
    }
}

if (sum >= 12)
{
    Console.WriteLine("Vitória!");
}
else
{
    Console.WriteLine("Você perdeu!");
}