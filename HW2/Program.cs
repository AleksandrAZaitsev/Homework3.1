﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;


if (numberA > max) 
{
    max = numberA;
}
else if (numberB > max) 
{
    max = numberB;
}

else if (numberC > max); 
{
    max = numberC;
}

System.Console.WriteLine("Максимальное третье число и равно " + numberC);
