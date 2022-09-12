// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

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
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+ ", ");
    }
    Console.WriteLine(arr[arr.Length-1]+ ", ");
}

int arrLen = ReadData("Введите длину массива: ");
int[] array = GenArr(arrLen);
PrintArr(array);

PrintArr(GenArr(ReadData("Введите число "))); // сокращенный метод



// Вариант решения КОнстантин
// void PrintArray(int[] arr)
// {
//     string arrString = "";

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arrString += arr[i];
//     }

//     Console.WriteLine(arrString);
// }

// int[] GenArray(int arrLength)
// {
//     int[] array = new int[arrLength];

//     for (int i = 0; i < arrLength; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//     }
//     return array;
// }

// int[] array = GenArray(8);
// PrintArray(array);



//вТОРОЙ вариант решения

