// Console.Write("Insira um inteiro de 5 a 10: ");
// string? input;
// int value = 0;
// bool flag = false;

// do
// {
//     input = Console.ReadLine();

//     flag = int.TryParse(input, out value);

//     if (flag == false)
//     {
//         Console.Write("A entrada inserida não é um inteiro. Insira um inteiro: ");
//     }
//     else
//     {
//         if (!(value >= 5 && value <= 10))
//         {
//             Console.Write("O número inserido não esta entre 5 e 10. Insira outro inteiro: ");
//         }
//     }
// } while (flag == false || (value >= 5 && value <= 10) == false);

// Console.WriteLine("Entrada aceita.");

//XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

Console.Write("Insira seu cargo (Admin, Manager ou User): ");

string? input;
bool flag = false;

do
{
    input = Console.ReadLine();

    if (input != null)
    {
        input = input.Trim();
        input = input.ToLower();

        switch (input)
        {
            case "admin":
                flag = true;
                break;

            case "manager":
                flag = true;
                break;

            case "user":
                flag = true;
                break;

            default:
                Console.Write("Cargo informado não existe. Informe um cargo válido: ");
                break;
        }
    }
} while (!flag);

Console.WriteLine($"Cargo {input} aceito.");