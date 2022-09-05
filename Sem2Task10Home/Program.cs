// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.


Console.Write("Введите число: ");
string? inputLineA = Console.ReadLine();
int inputNumberA = int.Parse(inputLineA);

if (inputNumberA > 100 && inputNumberA < 1000)
{
    int firstDigit = inputNumberA / 10; // Получили старшее число
    int NumberX = firstDigit%10; // сложили цифры старшего и младшего числа
    Console.WriteLine("Вторая цифра заданного числа: " + NumberX);
}
else
{
    Console.WriteLine("Число не 3-х значное");
}