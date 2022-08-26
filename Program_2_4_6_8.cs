/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.WriteLine("Введите номер задачи: 2,4,6 или 8:");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{

case 2 : 
    {
        Console.WriteLine("Введите 2 целых числа a, b:");
        Console.Write("a= "); int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b= "); int b = Convert.ToInt32(Console.ReadLine());
        if (a>=b) 
            {Console.Write($"Максимальное число: {a}");} else {Console.Write($"Максимальное число: {b}");}
        
        break;    
    } //Zadacha 2

case 4:
    {
        Console.WriteLine("Введите 3 целых числа a, b, c:");
        Console.Write("a= "); int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b= "); int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("c= "); int c = Convert.ToInt32(Console.ReadLine());
        if (a>=b && a>=c) {Console.Write($"Максимальное число: {a}");}
        if (b>=a && b>=c) {Console.Write($"Максимальное число: {b}");}
        if (c>=a && c>=b) {Console.Write($"Максимальное число: {c}");}
        
        break;
    } //Zadacha 4
    
case 6:
    {
        Console.WriteLine("Введите любое целое число a:"); int a = Convert.ToInt32(Console.ReadLine());
        int ost = a % 2;
        if ( ost == 0) {Console.Write("Число четное");} else {Console.Write("Число нечетное");}

        break;    
    } //Zadacha 6

case 8:
    {
        Console.WriteLine("Введите любое целое число N:"); int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Четные числа от 1 до N:");
        for (int i = 1; i <=N ; i++)
        {
            int ost = i % 2;
            if (ost == 0) {Console.Write($" {i} ,");}
        }
        break;
    } //Zadacha 8
 

}
