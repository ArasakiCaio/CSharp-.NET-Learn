Console.Write("Insira um inteiro de 5 a 10: ");
string? input;
int value = 0;
bool flag = false;

do
{
    input = Console.ReadLine();

    flag = int.TryParse(input, out value);

    if (flag == false)
    {
        Console.Write("A entrada inserida não é um inteiro. Insira um inteiro: ");
    }
    else
    {
        if (!(value >= 5 && value <= 10))
        {
            Console.Write("O número inserido não esta entre 5 e 10. Insira outro inteiro: ");
        }
    }
} while (flag == false || (value >= 5 && value <= 10) == false);

Console.WriteLine("Entrada aceita.");