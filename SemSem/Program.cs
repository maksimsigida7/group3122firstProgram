// Задача A1.1. Дано расстояние в сантиметрах. 
// Найти число полных метров в нем.

void A11()

{

Console.Write("Введите кол-во см: ");
string? inputLineA = Console.ReadLine();
int inputNumberA = int.Parse(inputLineA);

if (inputLineA != null) // проверили что было не было пустым
{
    Console.WriteLine("Число полных метров в нем " + inputNumberA / 100);
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}
}
//==========================================================


// Задача A1.2. Дана масса в килограммах.  
// Найти число полных центнеров в ней.

void A12()

{

Console.Write("Введите массу в килограммах: ");
string? inputLineA = Console.ReadLine();
int inputNumberA = int.Parse(inputLineA);

if (inputLineA != null) // проверили что было не было пустым
{
    Console.WriteLine("Число полных центнеров " + inputNumberA / 100);
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}
}

//============================================================
// Задача 1.3. Дана масса в килограммах.  
// Найти число полных тонн в ней.

void A13()

{

Console.Write("Введите массу в килограммах: ");
string? inputLineA = Console.ReadLine();
int inputNumberA = int.Parse(inputLineA);

if (inputLineA != null) // проверили что было не было пустым
{
    Console.WriteLine("Число полных тонн " + inputNumberA / 1000);
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}
}

A13();