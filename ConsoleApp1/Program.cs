using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Jorge!, ingrese los numeros correspondientes para realizar la suma. ");
            Console.WriteLine("Ingrese el primer numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int suma = a + b;
            Console.WriteLine("La suma es: "+suma) ;
        }
    }
}
