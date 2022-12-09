using System;

namespace llenarmatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa numero de matriz solo enteros\n");

            int[,] matriz = new int[3, 4];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Ingresa "+i+","+j+": ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    matriz[i,j] = numero;
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i,j]);
                }
                Console.Write("\n");
            }
        }
    }
}
