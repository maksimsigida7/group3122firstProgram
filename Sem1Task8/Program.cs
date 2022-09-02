//========================================================
// #8 Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// =======================================================

string? inputLineN = Console.ReadLine(); //считали первое число от пользователя 
        
if (inputLineN != null) // проверили чтоб поле не было пустым
{
    int inputNumberN = int.Parse(inputLineN); // превратили значение в целове число
    if (inputNumberN > 1) // убедились что число было больше 1
    {    
        int startNumber = 2; // стартуем с 1
        while (startNumber < inputNumberN) // входим в цикл увеличивая каждое последдующее число на 1

    {
        Console.WriteLine(startNumber);
        startNumber = startNumber + 2;
    }
    
    }
}