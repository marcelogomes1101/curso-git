using System;

namespace ExercicioMatriz01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];



            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe três valores separados por espaço ");
                string[] values = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            // imprime os registros da diagonal
            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i, i] + " ");

            }
            
            // impreme os registros negativos
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Nagative numbers: " + count);


            switch (switch_on)
            {
                default:
            }


        }
    }
}
