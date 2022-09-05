// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение n:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение m:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write(Ack(n, m));

        static int Ack(int n, int m)
        {
            if (n==0)
            {
                return m+1;
            }
            else if ((n != 0)&&(m==0))
            {
                return Ack (n-1,1);
            }
            else
            {
                return Ack (n-1, Ack(n,m-1));
            }
        }
    } 
}


