using System;

namespace promedioVector
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicializar-instanciar variables
            int[] vector1 = new int[2];
            double suma = 0;
            double promedio = 0.00;
            
            //Capturar valores de teclado
            Console.Write("\n\n\t Ingresa numeros del vector\n\n");
            for (int i = 0; i < vector1.Length; i++) 
            {
               int j = i+1;
               Console.Write("Posición - "+j+":");
               int numero = Convert.ToInt32(Console.ReadLine());
               vector1[i] = numero;
            }

            //Calculos

            //suma
            for (int i = 0; i < vector1.Length; i++) 
            {
               suma = suma + vector1[i];
            }

            promedio = suma/vector1.Length;

            //Mostrar resultado
            Console.Write("Promedio del vector : {0:F}",promedio);

        }
    }
}
