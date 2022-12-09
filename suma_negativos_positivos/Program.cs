using System;
using System.Collections;
namespace suma_negativos_positivos{
    class Program{
        static void Main(string[] args){
            int sumaPositivos = 0; 
            int sumaNegativos = 0; 
            
            bool i = false;
            while (i != true)
            {
                Console.WriteLine("Ingrese numero:");
                try{
                    int numero = int.Parse(Console.ReadLine()); 
                    if(int.Parse(numero.ToString()) > 0) 
                        sumaPositivos = sumaPositivos + int.Parse(numero.ToString());
                    else 
                        sumaNegativos = sumaNegativos + int.Parse(numero.ToString());
                    
                    if(numero == 0)
                        i = true;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Solo numeros enteros. ¡Por favor!");
                }
            }
            
            Console.WriteLine("suma numeros positivos:"+sumaPositivos);
            Console.WriteLine("suma numeros negativos:"+sumaNegativos);
        }
    }
}