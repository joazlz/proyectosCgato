using System;
using System.Collections;
namespace pares_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            var pares = new ArrayList();
            var impares = new ArrayList();
            var arrayIngresando = new ArrayList();
            var cantidadNumeros = 5 ; 

            for(int f=0;f<cantidadNumeros ;f ++)
            {
                Console.WriteLine("Introduce numero ("+f+"):");
                try
                {
                    arrayIngresando.Add(int.Parse(Console.ReadLine()));
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Solo numeros enteros. ¡Por favor!");
                    f --;
                }
            }
            
            foreach (var numero in arrayIngresando)
            {
                if( int.Parse(numero.ToString()) % 2 != 0 ) {
                    impares.Add(numero);
                }else {
                    pares.Add(numero);
                }
            }
            
            Console.Write("\t Pares\n");
            foreach (var numero in pares)
                Console.Write(numero+"\n");
            
            Console.Write("\t Impares\n");
            foreach (var numero in impares)
                Console.Write(numero+"\n");
            
        }
    }
}