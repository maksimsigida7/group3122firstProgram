//========================================================
// #2 Напишите программу которая на вход принимает 2 числа
//  и на выходе выдает какое число меньше а какое больше.
// =======================================================


string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

        if (inputNumberA > inputNumberB) // убедились что число 3-х значное

    Console.WriteLine("Число А больше числа В");
    else
    Console.WriteLine("Число B больше числа A");

}