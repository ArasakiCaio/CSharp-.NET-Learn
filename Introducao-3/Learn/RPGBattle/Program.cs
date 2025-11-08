Random dice = new Random();

int hero = 10;
int monster = 10;

Console.WriteLine("Início da batalha");
Console.WriteLine($"Vida do Herói: {hero}/10");
Console.WriteLine($"Vida do Monstro: {monster}/10\n");

do
{
    Console.Write("Turno do Herói - ");
    int damage = dice.Next(0, 11);
    Console.WriteLine($"Dano: {damage}");

    monster -= damage;
    Console.WriteLine($"Vida do Monstro: {monster}/10\n");

    if (monster <= 0)
    {
        Console.WriteLine("O Monstro morreu. Vitória do Herói!");
        continue;
    }

    Console.Write("Turno do Monstro - ");
    damage = dice.Next(0, 11);
    Console.WriteLine($"Dano: {damage}");

    hero -= damage;
    Console.WriteLine($"Vida do Herói: {hero}/10\n");

    if (hero <= 0)
    {
        Console.WriteLine("O Herói morreu. Vitória do Monstro!");
        continue;
    }

} while (hero > 0 && monster > 0);