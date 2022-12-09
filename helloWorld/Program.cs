using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=30 ; i>= 0; i--){
                Console.Write("{0}\n",i);
                i = i -2;
            }
        }
    }
}