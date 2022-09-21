// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int Count(int M)
{
    int res = 0;
    for (int i = 0; i < M; i++)
        {
            int num = ReadData("Введите число ");
            {
                if (num > 0) 
                {
                    res++;
                }
            }
        }
    
    return res;
}

int num = ReadData("Введи число М (количество чисел): ");
int numbCount = Count(num);
PrintResult("Количество чисел больше 0: " + numbCount);