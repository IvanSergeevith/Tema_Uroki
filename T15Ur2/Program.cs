﻿//Домашнее задание. Тема 15. Урок 2. Одномерный
//массив.

//1.Создайте пустой числовой массив размером в 10 ячеек.
//2. Заполните его случайными числами используя класс Random и цикл
//For.
//3. С помощью следующего цикла for выведите на экран все числа
//массива.
//4. Составьте цикл, проверяющий количество четных чисел.
//5. Выведите на экран количество четных чисел массива.
//Постарайтесь выполнить задание самостоятельно, не переходя к
//пояснению


int rezalt1 = 0;
 int rezalt = 0;
 int[] ints = new int[10];
for (int i = 0; i < 10; i++)
{


    Random random = new Random();
    int n = random.Next(1, 100);

    ints[i] = n;
    Console.WriteLine($"{n}");
    for (int j = 0; j < 10; j++)
    {
     if (n %2==0)
     {

        ++rezalt1;
        rezalt = rezalt + n;
        
        break;
     }
    }

}
Console.WriteLine($" Кол-во четных чисел {rezalt1}");
Console.WriteLine($" Сумма четных чисел {rezalt}");





