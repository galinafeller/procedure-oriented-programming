using System;

//  Информация за один месяц о вырученных от продаж и потраченных на закупки финансах (одновременно в одном массиве). Данные в массиве должны храниться за каждый день месяца.
namespace Array_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] finances = new int[12, 2];

            for (int n = 0; n < finances.GetLength(0); n++)
            {
                for (int m = 0; m < finances.GetLength(1); m++)
                {
                    if (m == 0)
                    {
                        Console.WriteLine("Sales proceeds in " + (n + 1) + " month: ");
                    }
                    else
                    {
                        Console.WriteLine("Spended to procurements in " + (n + 1) + " month: ");
                    }
                    finances[n, m] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            System.Console.WriteLine("Month\tIn\tOut\n");
            for (int n = 0; n < finances.GetLength(0); n++)
            {
                System.Console.Write("[" + (n + 1) + "]\t");
                for (int m = 0; m < finances.GetLength(1); m++)
                {
                    Console.Write(finances[n,m] + "\t");
                }
                Console.WriteLine();
            } 
        }
    }
}
