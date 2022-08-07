// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int a = Convert.ToInt32(Console.ReadLine());
    if (a<2)
    Console.WriteLine("Нет четных чисел");
    for (int b = 2;b<=a;b+=2)
    Console.WriteLine(b);