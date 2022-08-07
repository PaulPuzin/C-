// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
Console.WriteLine("Число а большее, Число b меньшее");
else if (a<b)
Console.WriteLine("Число b большее, Число a меньшее");