﻿Console.WriteLine("Введи первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

//if(numberA > max ) max = numberA;
if(numberB > max ) max = numberB;
if(numberC > max ) max = numberC;

Console.WriteLine(max);