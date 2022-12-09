using System;

namespace rellenarMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int[,] matriz = new int[4, 4];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
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
