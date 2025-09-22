Random random = new Random();

int daysToExpiration = random.Next(12);
int discountPercentage = 0;

if (daysToExpiration <= 0)
{
    Console.WriteLine("Sua assinatura expirou.");
}
else if (daysToExpiration <= 1)
{
    Console.WriteLine("Sua assinatura expira em um dia!");
    discountPercentage = 20;
}
else if (daysToExpiration <= 5)
{
    Console.WriteLine($"Sua assinatura expira em {daysToExpiration} dias!");
    discountPercentage = 10;
}
else if (daysToExpiration <= 10)
{
    Console.WriteLine("Sua assinatura expira logo. Renove agora!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renove agora e tenha {discountPercentage}% de desconto!");
}