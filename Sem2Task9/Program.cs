// напишите программу которая выводит случайное число от 10 до 99 и показывает наибольшую цифру числа
void MyVariant()
{
    Console.WriteLine("Метод 1");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);

    int firstDigit = number / 10; //определили число старшего разряда
    int secondDigit = number % 10; //определили число младшего разряда
                                   // Вариант 1
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void EvgeniyVariant()
{
    Console.WriteLine("Метод 2");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);
    Console.WriteLine(number);

    int firstDigit = number / 10; //определили число старшего разряда
    int secondDigit = number % 10; //определили число младшего разряда
    // Вариант 2
    Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
}

void CharVariant()
{
    Console.WriteLine("Метод 3");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10; //определили число старшего разряда
    int secondDigit = number % 10; //определили число младшего разряда

    // Вариант 3 - Char

    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
}

CharVariant();
EvgeniyVariant();
MyVariant();

// void MyVariant1()
// {
// System.Random numberGenerator = new Sistem.Random();

// int number = numberGenerator.Next(10, 100);

// Console.ReadLine();

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) ;
// {
//     Console.WriteLine(firstDigit);
// }
// else
// {
//     Console.WriteLine(secondDigit);
// }
// }
// void MyVariant2()


// {
// System.Random numberGenerator = new Sistem.Random();

// int number = numberGenerator.Next(10, 100);

// Console.ReadLine();

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) ;
// {
//     Console.WriteLine(firstDigit);
// }
// else
// {
//     Console.WriteLine(secondDigit);
// }
// }