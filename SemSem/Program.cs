// // Задача A1.1. Дано расстояние в сантиметрах. 
// // Найти число полных метров в нем.

// void A11()

// {

// Console.Write("Введите кол-во см: ");
// string? inputLineA = Console.ReadLine();
// int inputNumberA = int.Parse(inputLineA);

// if (inputLineA != null) // проверили что было не было пустым
// {
//     Console.WriteLine("Число полных метров в нем " + inputNumberA / 100);
// }
// else
// {
//     Console.WriteLine("Вы ввели неверное число");
// }
// }
// //==========================================================


// // Задача A1.2. Дана масса в килограммах.  
// // Найти число полных центнеров в ней.

// void A12()

// {

// Console.Write("Введите массу в килограммах: ");
// string? inputLineA = Console.ReadLine();
// int inputNumberA = int.Parse(inputLineA);

// if (inputLineA != null) // проверили что было не было пустым
// {
//     Console.WriteLine("Число полных центнеров " + inputNumberA / 100);
// }
// else
// {
//     Console.WriteLine("Вы ввели неверное число");
// }
// }

// //============================================================
// // Задача 1.3. Дана масса в килограммах.  
// // Найти число полных тонн в ней.

// void A13()

// {

// Console.Write("Введите массу в килограммах: ");
// string? inputLineA = Console.ReadLine();
// int inputNumberA = int.Parse(inputLineA);

// if (inputLineA != null) // проверили что было не было пустым
// {
//     Console.WriteLine("Число полных тонн " + inputNumberA / 1000);
// }
// else
// {
//     Console.WriteLine("Вы ввели неверное число");
// }
// }

// A13();



// Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран 


// Метод считывания данных пользователя
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

int[] GenArr(int num)
{
    Random rnd = new Random(); // создали рандом
    int[] arr = new int[num]; // создали массив
    for (int i = 0; i < arr.Length; i++) // заполнили циклом
    {
        arr[i] = rnd.Next(0, 3); // выбираем цифры массива от 0 до 10
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    if 
    Console.WriteLine(arr[arr.Length - 1]);
}

int arrLen = ReadData("Введите длину массива: ");
int[] array = GenArr(arrLen);
PrintArr(array);

PrintArr(GenArr(ReadData("Введите число "))); // сокращенный метод
