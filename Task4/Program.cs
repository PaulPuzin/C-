// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max;
    if (a > b)
            {
                if (a > c)
                {
                    max = a;
                }
                else max = c;
            }
    else if (b > c)
            {
              max = b;
            }
            else max = c;
    Console.WriteLine(max);