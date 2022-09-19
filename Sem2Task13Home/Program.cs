// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

void Variant1()
//Вариант только с 3-х значными числами.
{
    Console.Write("Введите число: ");
    string? inputLineA = Console.ReadLine();
    int inputNumberA = int.Parse(inputLineA);

    if (inputNumberA > 100 && inputNumberA < 1000)
    {
        int lastDigit = inputNumberA % 10;
        Console.WriteLine("Третья цифра заданного числа: " + lastDigit);
    }
    else
    {
        Console.WriteLine("Число не 3-х значное");
    }
}
// ===========================================================================

void Variant2()
// Вариант с неограниченным числом цифр.

{
    Console.Write("Введите число: ");
    string? inputLineA = Console.ReadLine();
    int inputNumberA = int.Parse(inputLineA);

    char[] charArray = inputNumberA.ToString().ToCharArray(); // Превращаем число в массив символов
    Console.WriteLine(charArray[2]); // Выводим вторую цифру массива
}
Variant1();
Variant2();