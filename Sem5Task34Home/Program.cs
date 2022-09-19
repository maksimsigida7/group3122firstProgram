// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.


// Универсальный метод генерации и заполнение массива
Console.WriteLine("Задайте размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrRandNumb(numbers);
Console.WriteLine("Сгенерированный массив: ");
PrintArray(numbers);
int count = 0;

for (int x = 0; x < numbers.Length; x++)
    if (numbers[x] % 2 == 0)
        count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");
// вывод массив
void FillArrRandNumb(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000); // задаем  параметры массива от 100 до 999.
    }
}

// вывод ответа
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}