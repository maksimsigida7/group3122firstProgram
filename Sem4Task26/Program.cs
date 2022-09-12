// Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.

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


// Вариент с длиной строки.
int CalculateDigits(int num)
{
    string numString = num.ToString(); //Разбиваем число на цифры
    return numString.Length; //Считываем количество цифр в числе
}


// второй метод
int CalculateDigitsString(int num)
{
    return (int)(Math.Log10(num) + 1);
}


// Третий метод
int DigitCount(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += 1;
        num = num / 10;
    }
    return num;
}

int number = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
int numberOfDigits = CalculateDigits(number);
Console.WriteLine(DateTime.Now - d1);
PrintResult("Количество цифр в числе: " + numberOfDigits);

DateTime d2 = DateTime.Now;
numberOfDigits = CalculateDigitsString(number);
Console.WriteLine(DateTime.Now - d2);
PrintResult("Количество цифр в числе: " + numberOfDigits);

DateTime d3 = DateTime.Now;
numberOfDigits = DigitCount(number);
Console.WriteLine(DateTime.Now - d3);
PrintResult("Количество цифр в числе: " + numberOfDigits);