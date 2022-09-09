// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом
//=================================================================


int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return number;
}

// Тест на палиндром


bool PalinTest(int Pal)
{
    if (Pal / 10000 == Pal % 10 && Pal / 1000 % 10 == Pal / 10 % 10)
    {
        return true;
    }
    else
    {
        return false;
    }
}



//Выводим данные вычисления
void PrintData(int Pal)
{
    if (Pal > 9999 && Pal < 99999) // убедились что число 5-х значное

    {
        if (PalinTest(Pal))
        {
            Console.WriteLine("Число " + Pal + " - является палиндромом");
        }
        else
        {
            Console.WriteLine("Число " + Pal + " - не является палиндромом");
        }

    }
    else
    {
        Console.WriteLine("Число " + Pal + " - не 5-ти значное");
    }
}

int Pal = ReadData("Введите 5-ти значный палиндромом: ");

PrintData(Pal);