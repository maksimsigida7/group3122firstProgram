// Напишгите программу которая выводит 3-х значное число и удаляет среднюю цифру этого чисала

void Variant1()
{
    Console.WriteLine("Метод 1");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine(number);

    int firstDigit = number / 100; // Получили старшее число
    int lastDigit = number % 10; // Получили младшее число

    int NumberX = firstDigit * 10 + lastDigit; // сложили цифры старшего и младшего числа
    Console.WriteLine(NumberX);

}

void Variant2()
{
    Console.WriteLine("Метод 2");

    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    int firstDigit = number / 100;
    int lastDigit = number % 10;

    Console.WriteLine(firstDigit * 10 + lastDigit);


}

void Variant3()
{
    Console.WriteLine("Метод 3");
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    int firstDigit = number / 100; //определили число старшего разряда
    int secondDigit = number % 10; //определили число младшего разряда

    char[] charArray = number.ToString().ToCharArray(); // Превращаем число в массив символов
    Console.Write(charArray[0]); 
    Console.WriteLine(charArray[2]);
    // Console.WriteLine("" + charArray[0] + charArray[2]); - Это четвертый метод с сокращением вывода

}

Variant1();
Variant2();
Variant3();

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