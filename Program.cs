﻿// Напишите программу, которая будет
// принимать на вход два числа и выводить,
//  является ли второе число кратным первому.
//   Если число 2 не кратно числу 1, то программа
//   выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4       34/5=6
// 16, 4 -> кратно                     16/4=4

// int num= new Random().Next(100,1000);

Console.WriteLine("Введите большее  число");
int num1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2=Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine("Кратны");
}
else
{
    // Console.WriteLine("Остаток от деления"+ num1 % num2); Канкатинация

    // Интерполяция
    Console.WriteLine($"Остаток от деления {num1 % num2}");
}