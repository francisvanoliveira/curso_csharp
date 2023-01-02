using System;

namespace Atribuicao{
    class Program{
        static void Main(string[] args){
            
            int n = 10;
            Console.WriteLine(n);

            n += 2;
            Console.WriteLine(n);

            n *= 3;
            Console.WriteLine(n);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s);

            Console.WriteLine("------------------------");
            Console.WriteLine("Aritméticos/Atribuição");

            int a1 = 10;
            a1++;
            Console.WriteLine("Incremento: " + a1);

            int a2 = 10;
            a2--;
            Console.WriteLine("Decremento: " + a2);

            int a3 = 10;
            int b3 = a3++;
            Console.WriteLine(a3);
            Console.WriteLine(b3);
            /*Nesse caso b3 recebeu primeiro o valor de a3 que é 10 e depois a3 foi incrementado, ficando com saída a3=11 e b3=10*/

            int a4 = 10;
            int b4 = ++a4;
            Console.WriteLine(a4);
            Console.WriteLine(b4);
            /*Nesse caso a4 foi incrementado antes de ser atribuido a b4, ficando com saida a4 e b4 = 11*/

        }
    }
}