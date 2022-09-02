//========================================================
// Напишите программу которая на вход принимает Одно число (N)
// а на выходе показывает все целые числа в промежутке от -N до N
// =======================================================


string? inputLineN = Console.ReadLine(); //считали число от пользователя

if (inputLineN != null) // проверили что бполе не было пустым
{
    int inputNumberN = int.Parse(inputLineN); // превратили значение в целове число
    if (inputNumberN > 0) // убедились что число было положительным
    {    
        int startNumber = (-1) * inputNumberN; // стартуем с отрицательного числа

        while (startNumber < inputNumberN) // входим в цикл увеличивая каждое последдующее число на 1

    {
        Console.Write(startNumber + ", ");
        startNumber = startNumber + 1;
    }
    Console.Write(inputNumberN );
    }
}