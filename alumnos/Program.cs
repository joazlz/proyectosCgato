using System;

namespace alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alumnos = new string[2];

            Console.Write(alumnos.Length);

            Console.Write("\n\n\t Ingresa el nombre de  los alumnos\n\n");
            for (int i = 0; i < alumnos.Length; i++) 
            {
                int j = i+1;
                Console.Write("Alumno no."+j+":");
               string nombre = Console.ReadLine();
               alumnos[i] = nombre;
            }

            Console.Write("\n\n\tLista de alumnos\n\n");
            for (int i = 0; i < alumnos.Length; i++) 
            {
                int j = i+1;
                if(j<alumnos.Length){
                   Console.Write(alumnos[i]+",");
                }else{
                    Console.Write(alumnos[i]);
                }
            }
        }
    }
}
