//========================================================
// #4 Напишите программу которая на вход принимает три числа 
// и выдает максимально е значение из этих числел.
// =======================================================


string? inputLineA = Console.ReadLine(); //считали первое число от пользователя 
string? inputLineB = Console.ReadLine(); //считали второе число от пользователя
string? inputLineX = Console.ReadLine(); //считали третье число от пользователя 

        
if (inputLineA != null && inputLineB != null && inputLineX != null) // проверили что было не было пустым

{
    int inputNumberA = int.Parse(inputLineA); // превратили значение в целое число
    int inputNumberB = int.Parse(inputLineB); // превратили значение в целое число
    int inputNumberX = int.Parse(inputLineX); // превратили значение в целое число

int D = Math.Max(inputNumberA, Math.Max(inputNumberB, inputNumberX));
//  if (inputNumberA > inputNumberB && inputNumberA > inputNumberX)
//     {
//         Console.WriteLine("Число A Максимальное");
//     }
//         else
//         if (inputNumberB > inputNumberA && inputNumberB > inputNumberX)
//         {
//             Console.WriteLine("Число B Максимальное");
//         }
//             else 
        Console.Write(D);
        Console.Write (" - Максимальное число");
}
    
