﻿// Задача 25

Console.Write("Введите число - ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степерь в которое хотите возвести число - ");
int numberB = Convert.ToInt32(Console.ReadLine());
    int exponentiation = Exponentiation(numberA, numberB);
    int Exponentiation(int numberA, int numberB)
    {

    int result = 1;
        for(int i=1; i <= numberB; i++)
        {
            result = result * numberA;
        }

    return result;
    }

   Console.WriteLine("Ответ: " + exponentiation);