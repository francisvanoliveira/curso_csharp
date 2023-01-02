/*Aula entrada de dados parte 1 - Lendo string*/

using System;

namespace Entrada{
    class Program{
        static void Main(string[] args){

            string frase = Console.ReadLine(); /*variável frase está recebendo o resultado do Console.ReadLine que será algo digitado pelo usuário*/
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            /*Split*/
            string[] v = Console.ReadLine().Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];


            Console.WriteLine("");
            Console.WriteLine("------ Resultado ------");
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine("Split:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}