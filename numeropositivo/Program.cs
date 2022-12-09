using System;

namespace numeropositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5,5];

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
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if(matriz[i,j] > 0){
                        Console.Write(matriz[i,j]);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
