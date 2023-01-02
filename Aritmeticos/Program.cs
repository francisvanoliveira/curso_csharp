using System;

namespace Aritmeticos{
    class Program{
        static void Main(string[] args){

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = (double) 10 / 8; /*ou double n4 = 10.0 / 8;*/

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.WriteLine("---------------------------");

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; /*Math.Pow(base, expoente) função para calcular potencia*/
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); /*Math.Sqrt() função para calcular raiz quadrada*/
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}