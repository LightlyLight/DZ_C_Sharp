﻿/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите три числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}
else
{
   Console.WriteLine("Числа равны"); 
}
Console.WriteLine($"Максимум равен {max}");

// Решение задачи через цикл

/*Console.WriteLine("Введите три числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
for (int i = 0; i < 3; i++)
{
        
}
Console.WriteLine($"Максимум равен {max}");*/