//Информация о прохождении профилактических осмотров автомобилей за месяц. 
//Каждый автомобиль должен раз в неделю пройти два вида осмотра (например, осмотр двигателя и осмотр кузова), по результатам которых ставятся отметки: прошел или не прошел. 
//Предположить количество автомобилей равным 30.
using System;

namespace Arrays
{
    class Vehikles
    {
        static void Main(string[] args)
        {
            int[,] vehikles = new int[30, 2];

            for (int n = 0; n < 30; n++)
            {
                for (int m = 0; m < 2; m++)
                {
                    Console.WriteLine("Vehicle # " + n + ". Please enter '0' for 'none' or '1' for 'done': ");
                    vehikles[n, m] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(vehikles[i, j] + " ");
                }
                Console.WriteLine();
            }

            System.Console.WriteLine(vehikles);
        }
    
    }
}
