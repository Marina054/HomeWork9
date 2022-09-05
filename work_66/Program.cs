// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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
             Console.WriteLine();
             int sum = 0;
             for (int i = M; i <= N; i++)
             {
                sum += i;
             }
             Console.WriteLine(sum);

        }
     
    } 
  