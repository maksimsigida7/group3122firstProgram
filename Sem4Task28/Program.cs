// Напишите программу, которая принимает на 
// вход число N и выдаёт произведение чисел от 1 до N.

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

// Вариант с логарифмом
long CalculateFactorial(int num)
{
    long factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

long CalcData (int num)
{
    if (num ==1)
    return 1;
    return num * CalcData (num-1);
}

int number = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
long factorial = CalculateFactorial(number);
Console.WriteLine(DateTime.Now - d1);
PrintResult("Факториал равен: " + factorial);

DateTime d2 = DateTime.Now;
long FactorialTolya = CalcData(number);
Console.WriteLine(DateTime.Now - d2);
PrintResult("Факториал равен: " + factorial);