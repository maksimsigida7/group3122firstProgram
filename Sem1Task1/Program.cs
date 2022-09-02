//========================================================
// Напишите программу которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго.
// =======================================================


string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    //bool outRusult = (inputNumberA * inputNumberA == inputNumberB);
    bool outRusult = (inputNumberB / inputNumberA == inputNumberA);

    Console.WriteLine(outRusult);
}