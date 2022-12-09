using System;
using System.Collections;
namespace positivos_negarivos{
    class Program{
        static void Main(string[] args){
            var positivos = new ArrayList();
            var negativos = new ArrayList();
            var arrayIngresando = new ArrayList();
            var cantidadNumeros = 5 ; 

            for(int f=0;f<cantidadNumeros ;f++){
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
            
            foreach (var numero in arrayIngresando){
                if( int.Parse(numero.ToString()) > 0 ) {
                    positivos.Add(numero);
                }else {
                    negativos.Add(numero);
                }
            }
            
            Console.Write("\t Positivos\n");
            foreach (var numero in positivos)
                Console.Write(numero+"\n");
            
            Console.Write("\t Negativos\n");
            foreach (var numero in negativos)
                Console.Write(numero+"\n");
            
        }
    }
}
