Random coin = new Random();

Console.WriteLine($"O resultado do lançamento da moeda foi: {(coin.Next(2) == 0 ? "Cara":"Coroa")}");