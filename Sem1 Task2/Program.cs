//========================================================
// #2 Напишите программу которая на вход принимает 2 числа
//  и на выходе выдает какое число меньше а какое больше.
// =======================================================


string? inputLineA = Console.ReadLine(); //считали первое число от пользователя 
string? inputLineB = Console.ReadLine(); //считали второе число от пользователя

        
if (inputLineA != null && inputLineB != null) // проверили что было не было пустым

{
    int inputNumberA = int.Parse(inputLineA); // превратили значение в целое число
    int inputNumberB = int.Parse(inputLineB); // превратили значение в целое число

// {
// if (inputNumberA = inputNumberB) // Проверили сравнение чисел
//     Console.WriteLine("Числа равны");
// }
        if (inputNumberA > inputNumberB) // Проверили сравнение чисел
    Console.WriteLine("Число 1 больше числа 2");
    else
    Console.WriteLine("Число 2 больше числа 1");

}