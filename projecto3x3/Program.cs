using System;

namespace projecto3x3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];
            int[] sumasFilas = new int[3];
            int[] sumasColumnas = new int[3];
            int sFila = 0;
            int sColumn= 0;

            Console.Write("Ingresa numero de matriz solo enteros\n");

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
                sFila = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    sFila = sFila + matriz[i,j];
                    sumasFilas[i] = sFila;
                }
                Console.Write("\n");
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                sColumn = 0;
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    sColumn = sColumn + matriz[j,i];
                    sumasColumnas[i] = sColumn;
                }
                Console.Write("\n");
            }

            Console.Write("\nsumasFilas:");
            foreach (var item in sumasFilas)
            {
                Console.Write(item+"-");
            }

            Console.Write("\nsumasColumnas:");
            foreach (var item in sumasColumnas)
            {
                Console.Write(item+"-");
            }
        }
    }
}
