﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 3, l = 3, m = 0,  format =5;
            Console.WriteLine("Enter your first parametr: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second parametr: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Format");
            format = Convert.ToInt32(Console.ReadLine());
            
            int[,] myMatrix;
            myMatrix = new int[k, l];
            int z = l;
            for (int i = 0; i < k; i++)

                for (int j = 0; j < l; j++)
                    myMatrix[i, j] = i * j;

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++) ;


                // Console.Write($" {myMatrix[i, j],4}" + "\t");
                // Console.WriteLine();
            }

            //Вверх матриці, будується один раз
            Console.Write("╔"+TakeStringNtimes("═", format));
            for (int n = 0; n < (k - 1); n++)
                Console.Write("╦"+ TakeStringNtimes("═", format));
            Console.Write("╗");
            Console.WriteLine();


            //Вертикальні рядки матриці
            for (m = 0; m < (l - 1); m++)
            {
                Console.Write("║");
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < l; j++)
                        myMatrix[i, j] = i * j;
                    Console.Write($"{myMatrix[i, m].ToString().PadLeft(format)}" + "║");
                }

                //
                Console.WriteLine();
                Console.Write("╠"+ TakeStringNtimes("═", (format/2+1)));
                for (int n = 0; n < (k - 1); n++)
                    Console.Write(TakeStringNtimes("═", (format / 2)) + "╬"+ TakeStringNtimes("═", (format / 2+1)));
                Console.Write(TakeStringNtimes("═", (format / 2)) + "╣");
                Console.WriteLine();
            }

            // Останній рядок

            Console.Write("║");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                    myMatrix[i, j] = i * j;
                Console.Write($"{myMatrix[i, (l - 1)].ToString().PadLeft(format)}" + "║");
            }
            Console.WriteLine();

            //Низ матриці будується один раз
            Console.Write("╚"+TakeStringNtimes("═", format));
            for (int n = 0; n < (k - 1); n++)
                Console.Write("╩"+ TakeStringNtimes("═", format));
            Console.Write("╝");
            Console.WriteLine();







            //Console.WriteLine();
            //Console.WriteLine("\t╔═════╦═════╦═════╗");
            //Console.WriteLine($"\t║ {myMatrix[0, 0],3} ║ {myMatrix[0, 1],3} ║ { myMatrix[0, 2],3} ║");
            //Console.WriteLine("\t╠═════╬═════╬═════╣");
            //Console.WriteLine($"\t║ {myMatrix[1, 0],3} ║ {myMatrix[1, 1],3} ║ { myMatrix[1, 2],3} ║");
            //Console.WriteLine("\t╠═════╬═════╬═════╣");
            //Console.WriteLine($"\t║ {myMatrix[2, 0],3} ║ {myMatrix[2, 1],3} ║ { myMatrix[2, 2],3} ║");
            //Console.WriteLine("\t╚═════╩═════╩═════╝");


            Console.WriteLine();
            Console.ReadKey();


            var newString = TakeStringNtimes("═", format);

            // 5, "═" --> ══════


            Console.WriteLine(newString);
        }

        private static string TakeStringNtimes(string input, int count)
        {
            string result = String.Empty;
           
            for (int i = 0; i < count; i++)
            {
                result += input;
            }
            return result;
        }
    }
}
