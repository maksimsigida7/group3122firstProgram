// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

void VariantNomer1()
{
    Console.Write("Введите число: ");
    string? inputLineA = Console.ReadLine();
    int inputNumberA = int.Parse(inputLineA);

    if (inputNumberA > 100 && inputNumberA < 1000)
    {
        int firstDigit = inputNumberA / 10; // Получили старшее число
        int NumberX = firstDigit % 10; // 
        Console.WriteLine("Вторая цифра заданного числа: " + NumberX);
    }
    else
    {
        Console.WriteLine("Число не 3-х значное");
    }
}
// ============================================================================
void VariantNomer2()

{
    Console.Write("Введите число: ");
    string? inputLineA = Console.ReadLine();
    int inputNumberA = int.Parse(inputLineA);

    char[] charArray = inputNumberA.ToString().ToCharArray(); // Превращаем число в массив символов
    Console.WriteLine(charArray[2]); // Выводим вторую цифру массива

    // else
    // {
    //     Console.WriteLine("Число не 3-х значное");
    // }

}
VariantNomer1();
VariantNomer2();