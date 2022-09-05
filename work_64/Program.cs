// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""
using System;

   class Program
   {
         static void Main()
        {
             Console.WriteLine("Введите значение M:");
             int M = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Введите значение N:");
             int N = Convert.ToInt32(Console.ReadLine());
             if (M >= N)
             {
                 Console.WriteLine("you enter M >= N");
                 return;
             }
             for (int i = M; i <= N; i++)
             {
                 Console.Write("{0} ", i);
             }

        }
     
    } 