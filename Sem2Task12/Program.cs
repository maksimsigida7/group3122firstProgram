//-----------------------------------------------------------------------------------------------------------
//                                      Задача 12
//Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит остаток от деления.
//-----------------------------------------------------------------------------------------------------------void MyVariant()

// void Variant1()

// {
//     Console.WriteLine("Введите первое число");
//     string? inputLineA = Console.ReadLine(); //считали первое число от пользователя 
//     Console.WriteLine("Введите второе число");
//     string? inputLineB = Console.ReadLine(); //считали второе число от пользователя

//     if (inputLineA != null && inputLineB != null) // проверили что было не было пустым

//     {
//         int inputNumberA = int.Parse(inputLineA); // превратили значение в целое число
//         int inputNumberB = int.Parse(inputLineB); // превратили значение в целое число

//         R = (inputNumberB % inputNumberA == 0);
//         if (R) // Проверили сравнение чисел
//             Console.WriteLine("Число B кратно А");
//         else
//             Console.WriteLine("Число В не кратно");

//     }
// // }


// void Variant2()
// {
//     Console.Write("Введите первое число: ");
//     string? inputLineA = Console.ReadLine();
//     Console.Write("Введите второе число: ");
//     string? inputLineB = Console.ReadLine();

//     int inputNumberA = int.Parse(inputLineA);
//     int inputNumberB = int.Parse(inputLineB);

//     Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления: " + inputNumberB % inputNumberA));
// }

// void Variant3()
// {
//     string? inputLineA = Console.ReadLine();
//     string? inputLineB = Console.ReadLine();

//     if (inputLineA != null && inputLineB != null)
//     {
//         int inputNumberA = int.Parse(inputLineA);
//         int inputNumberB = int.Parse(inputLineB);

//         Console.WriteLine(inputNumberB % inputNumberA == 0 ? "Является кратным" : inputNumberB % inputNumberA);
//     }
// }



int inputNumberA = 0;
int inputNumberB = 0;
bool result = false;

ReadData();
CalculateData();
PrintData();

// Получаем два числа
void ReadData()
{
    Console.Write("Введите первое число: ");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число: ");
    string? inputLineB = Console.ReadLine();

    inputNumberA = int.Parse(inputLineA);
    inputNumberB = int.Parse(inputLineB);
}

// Определяем кратность чисел
void CalculateData()
{
    result = (inputNumberB % inputNumberA == 0);
}

//Выводим данные вычисления
void PrintData()
{
    if (result)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else
    {
        Console.WriteLine("Остаток от деления: " + inputNumberB % inputNumberA);
    }
}