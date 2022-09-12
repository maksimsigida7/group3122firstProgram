// Напишите цикл, который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B.


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


// Вариант 1
long PowVariant(int num1, int num2)
{
    long resultPow = 1;
    for (int i = 0; i < num2; i++)
    {
        resultPow = resultPow * num1;
    }
    return resultPow;
}

// Вариант 2
double PowMath(int num1, int num2)
{
    double resultPow = 0;
    resultPow = Math.Pow(num1, num2);
    return resultPow;
}


int num1 = ReadData("Введите число: ");
int num2 = ReadData("Введите степень: ");

DateTime d1 = DateTime.Now;
long resultPow = PowVariant(num1, num2);
Console.WriteLine(DateTime.Now - d1);
PrintResult(num1 + " в степени " + num2 + " равняется " + resultPow);

DateTime d2 = DateTime.Now;
double resultPow1 = PowMath(num1, num2);
Console.WriteLine(DateTime.Now - d2);
PrintResult(num1 + " в степени " + num2 + " равняется " + resultPow);