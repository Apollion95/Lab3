using System;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //  int[][] tablicaPoszarpana = new int[4][];
            //  Console.Write(tablicaPoszarpana.Length[i][j])// GetLenght(0);

            int[][] tablicaPoszarpana = new int[][]
            {
                new int[]{1,2,3,4,5},
                new int[]{9,8},
                new int[]{4,5,6,7}
            };

            int suma=0;
            for (int i = 0; i < tablicaPoszarpana.Length; i++)
            {
                for (int j = 0; j < tablicaPoszarpana[i].Length; j++)
                {
                    suma += tablicaPoszarpana[i][j];
                }
            }
            Console.WriteLine("Suma tablicy to " + suma + "");


            Console.WriteLine("Podaj zdanie");
            string zdanie = Console.ReadLine();

            zdanie = char.ToUpper(zdanie[0]) + zdanie.Substring(1);

            if (zdanie.EndsWith("."))
            {
                Console.WriteLine(zdanie);
            }
            else
            {
                StringBuilder builder = new StringBuilder(zdanie);
                builder.Append(".");
                Console.WriteLine(builder);
            }




        }
    }
}
