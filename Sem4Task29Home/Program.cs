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
        arr[i] = rnd.Next(0, 10); // выбираем цифры массива от 0 до 10
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + ", ");
}

int arrLen = ReadData("Введите длину массива: ");
int[] array = GenArr(arrLen);
PrintArr(array);

PrintArr(GenArr(ReadData("Введите число "))); // сокращенный метод