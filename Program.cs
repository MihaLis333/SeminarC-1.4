﻿// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int NumOfDigits(int num)
{
    int count = 0;

    while(num != 0)
    {
        count++;
        num /= 10; // num = num / 10;
    }
    return count;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = NumOfDigits(number);

Console.WriteLine($"Количество цифр в {number} равна {result}. ");
*/

// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int sumNumber(int num)
{
    int count = 1;

    while(num > 1)
    {
        count += num;
        num--;
    }
    return count;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = sumNumber(number);

Console.WriteLine($"Сумма чисел равна {result}");
*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.


int factorial(int num)
{
    int count = 1;

  /* while(num > 1) // еще вариант решения.
   {
    count *= num;
    num--;
   }
   return count;*/

   for(int i = 1; i <= num; i++)
   {
    count *= i;
   }
   return count;
}


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = factorial(number);

Console.WriteLine($"Факториал числа равна {result}");
