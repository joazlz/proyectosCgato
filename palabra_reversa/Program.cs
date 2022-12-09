using System;

namespace palabra_reversa
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Ingresa Palabra:");
            
            string ingresada = Console.ReadLine();
            string reversa = "";
            
            for (int i=ingresada.Length-1 ; i>= 0; i--){
                reversa = reversa + ingresada.Substring(i,1);
            }
            
            Console.Clear();
            Console.Write("Palabra ingresada: "+ingresada+"\n");
            Console.Write("Palabra reversa:"+ reversa +"\n");
        }
    }
}
