// string[] fraudulentOrderIds = ["A123", "B456", "C789"];

// fraudulentOrderIds[0] = "A123";
// fraudulentOrderIds[1] = "B456";
// fraudulentOrderIds[2] = "C789";

// Console.WriteLine($"First: \t{fraudulentOrderIds[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIds[1]}");
// Console.WriteLine($"Third: \t{fraudulentOrderIds[2]}\n");

// fraudulentOrderIds[0] = "E321";
// fraudulentOrderIds[1] = "F654";
// fraudulentOrderIds[2] = "G987";

// Console.WriteLine($"Reassign First: {fraudulentOrderIds[0]}");
// Console.WriteLine($"Reassign Second: {fraudulentOrderIds[1]}");
// Console.WriteLine($"Reassign Third: {fraudulentOrderIds[2]}\n");

// Console.WriteLine($"There are {fraudulentOrderIds.Length} fraudulent orders to process.\n");

// string[] names = { "Caio", "Camila", "Carina" };

// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// int[] inventory = [200, 450, 750, 175, 250];
// int sum = 0;
// int bin= 0;

// foreach (int item in inventory)
// {
//     sum += item;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");

string[] Ids = {"B123",
                "C234",
                "A345",
                "C15",
                "B177",
                "G3003",
                "C235",
                "B179"
};

foreach (string id in Ids)
{
    if (id.StartsWith("B"))
    {
        Console.WriteLine($"Possível fraude: {id}");
    }
}