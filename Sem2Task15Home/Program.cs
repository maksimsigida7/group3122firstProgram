// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
//============================================================================


    Console.Write("Введите число: ");
    string? inputLineA = Console.ReadLine();
    int inputNumberA = int.Parse(inputLineA);

    if (inputNumberA == 6 || inputNumberA == 7)
    {
        Console.WriteLine("День недели - Выходной ");
    }
    else
    {
        if (inputNumberA > 7)
        {
            Console.WriteLine("Такого дня недели не существует ");
        }
        else
        {
            Console.WriteLine("День недели - не выходной");
        }

    }



