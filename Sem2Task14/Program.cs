// # 14. Напишите программу, которая принимает на вход 
// число и проверяет, кратно ли оно одновременно 7 и 23.

// ===========================================================================

// string? inputLineA = Console.ReadLine();
// if (inputLineA != null)
//     int inputNumberA = int.Parse(inputLineA);
// R1 = (inputNumberA%7==0);
// R2 = (inputNumberA%23==0);



// if (R1 && R2) // проверили что было не было пустым
// {
//     Console.Write("Число кратро 7 и 23");
// }
// else 
// {
//     Console.Write("Число не кратро 7 и 23");
// }



// ========================================================================
// Вариант 1

// int inputNumberA = 0;
// bool result = false;

// ReadData();
// CalculateData();
// PrintData();

// // Получаем два числа
// void ReadData()
// {
//     Console.Write("Введите первое число: ");
//     string? inputLineA = Console.ReadLine();

//     inputNumberA = int.Parse(inputLineA);
// }

// // Определяем кратность чисел
// void CalculateData()
// {
//     {
//         result = (inputNumberA % 7 == 0 && inputNumberA % 23 == 0);
//     }
// }
// //Выводим данные вычисления
// void PrintData()
// {
//     if (result)
//     {
//         Console.WriteLine("Число кратно 7 и 23");
//     }
//     else
//     {
//         Console.WriteLine("ЧИсло не кратно 7 и 23");
//     }

// }
// ==========================================================================
// Вариант 2.

// Console.Write("Введите число: ");
// string? inputLineA = Console.ReadLine();
// int inputNumberA = int.Parse(inputLineA);

// if (inputNumberA % 7 == 0 && inputNumberA % 23 == 0)
// {
//     Console.Write("Число кратно одновременно 7 и 23");
// }
// else
// {
//     Console.Write("Число не кратно одновременно 7 и 23");
// }
// ========================================================================


// Вариант 3. (ГАвно)
// int number, resultA, resultB;


// // Запрашивает число у пользователь, в качестве аргумента 
// // принимает текст запроса и команду выхода из программы.
// int RequestNumber(string text = "Enter number", string exitCmd = "q")
// {
//     while (true) // код в цикле выполняется пока пользователь не введет целое число или команду выхода из программы
//     {
//         Console.Write(text + ": ");
//         string? inputLine = Console.ReadLine();

//         if (inputLine == null)
//         {
//             continue;
//         }
//         if (inputLine.ToLower() == exitCmd)
//         {
//             Environment.Exit(0);
//         }
//         if (int.TryParse(inputLine, out int number))
//         {
//             return number;
//         }
//     }
// }

// // // чтение данных из сонсоли
// // void ReadData()
// // {
// //     number = RequestNumber("Enter number");
// // }

// // // Определяем крат

//=========================================================================


// Вариант 4. 
string? inputLineA = Console.ReadLine();
if (inputLineA != null) Console.Write(((int.Parse(inputLineA) % 7 == 0) && (int.Parse(inputLineA) % 23 == 0)) ? ("Кратно") : ("Не кратно"));

// ========================================================================