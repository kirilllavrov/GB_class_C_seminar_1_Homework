﻿Console.WriteLine("Введи число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введи число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int max = numberA;

//if(numberA > max ) max = numberA;
if(numberB > max ) max = numberB;

Console.Write("max = ");
Console.WriteLine(max);