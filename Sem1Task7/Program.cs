﻿//========================================================
// #7 Напишите программу которая на вход принимает трехзначное число]
// и на выходе показывает последнюю цифру этого числа.
// =======================================================


string? inputLine = Console.ReadLine(); //считали число от пользователя

if (inputLine != null) // проверили что быоле не было пустым
{
    int inputNumber = int.Parse(inputLine); // превратили значение в целове число
    if (inputNumber > 99 && inputNumber < 1000) // убедились что число 3-х значное
    {    
        int lastDigit = inputNumber%10; // проверяем последнее число
        Console.Write(lastDigit); //выводим последнее число (результат)
    }
}