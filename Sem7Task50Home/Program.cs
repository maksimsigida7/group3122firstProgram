// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
Fill2DArrRandNumb(numbers);

if (x < numbers.GetLength(0) || y < numbers.GetLength(1))
{
    Console.WriteLine($"Значение элемента {x} строки и {y} столбца равно: {numbers[x-1,y-1]}");
}
else
{
    Console.WriteLine("Такого элемента нет!!!");
}

PrintArray(numbers);

void Fill2DArrRandNumb(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " " + "\t");
        }   
        
        Console.WriteLine(""); 
    }
}