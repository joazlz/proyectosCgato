using System;

namespace sumaVectores
{
    class Program
    {
        static void Main(string[] args)
        {

            // Inicializar-instanciar variables
            int[] vector1 = new int[10];
            int[] vector2 = new int[10];
            int sumaV1 = 0;
            int sumaV2 = 0;

            //Capturar valores de teclado
            Console.Write("\n\n\t Ingresa numeros del primer vector\n\n");
            for (int i = 0; i < vector1.Length; i++) 
            {
               int j = i+1;
               Console.Write("Posición - "+j+":");
               int numero = Convert.ToInt32(Console.ReadLine());
               vector1[i] = numero;
            }

            Console.Write("\n\n\t Ingresa numeros del segundo vector\n\n");
            for (int i2 = 0; i2 < vector2.Length; i2++) 
            {
               int j2 = i2+1;
               Console.Write("Posición - "+j2+":");
               int numero2 = Convert.ToInt32(Console.ReadLine());
               vector2[i2] = numero2;
            }

            //calculo de sumas
            for (int i = 0; i < vector1.Length; i++) 
            {
               sumaV1 = sumaV1 + vector1[i];
            }

            for (int i2 = 0; i2 < vector2.Length; i2++) 
            {
               sumaV2 = sumaV2 + vector2[i2];
            }

            //Mostrar resultado

            Console.Write("suma Vector 1 : "+sumaV1+"\n\n");
            Console.Write("suma Vector 2 : "+sumaV2);
        }
    }
}
