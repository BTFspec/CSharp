﻿int n = 10;
int[] array = { 2, 3, 4, 5, 8, 7, 33, 22, 1, 9 };
int i = 0;

while(i < n)
{
    if(array[i] % 2 ==0)  //ищем четные элементы массива
    {
        Console.Write($"{array[i]} "); // выводим ответ
    }
    i = i + 1; // шаг плюс 1 по массиву перебераем все элементы массива
    
}