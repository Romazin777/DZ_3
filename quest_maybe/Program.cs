﻿// Необязательная задача_Напишите программу, которая считывает с консоли числа (по одному в строке) до тех пор, 
// пока сумма введённых чисел не будет равна 0 и сразу после этого выводит сумму квадратов всех считанных чисел.

int[] numb = { 1, -3, 5, -6, -10, 13, 4, -2, 10 };
int count = 0;
int sum = numb[count];
while (sum != 0)
{
    sum = sum + numb[count];
    count++;
}
Console.WriteLine(count);
