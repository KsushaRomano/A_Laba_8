﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            A[0] = 1;
            Console.Write(A[0]);
            Console.WriteLine();
            for (int i = 1; i < n; i++)
            {
                int l = 0;
                for (int j = 0; j <= i; j++)
                {
                    int p = A[j];
                    A[j] += l;
                    l = p;
                    Console.Write(A[j]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
            Console.Read();
        }
    }
}
