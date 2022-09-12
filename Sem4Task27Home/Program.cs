// Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.

// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string line)
{
    Console.WriteLine(line);
}



int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num%10;
        num = num / 10;
    }
    return sum;
}

int number = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int sumOfDigits = SumDigits(number);
Console.WriteLine(DateTime.Now - d1);
PrintResult("Сумма цифр в числе: " + sumOfDigits);