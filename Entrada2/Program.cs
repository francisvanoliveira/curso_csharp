/*Aula entrada de dados parte 2 - Lendo numeros*/

using System;
using System.Globalization;

namespace Entrada2{
    class Program{
        static void Main(string[] args){
            
            int n1 = int.Parse(Console.ReadLine()); /*Para ler uma valor inteiro tem que realizar a conversão com int.Parse()*/
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); /*Para ler uma valor double tem que realizar a conversão com double.Parse(). Foi o utilizado CultureInfo.InvariantCulture para caso usuário utilize o "." na impressão saia a ","*/
            char ch = char.Parse(Console.ReadLine()); /*Para ler uma valor char tem que realizar a conversão com char.Parse()*/

            /*Split*/
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(" ");
            Console.WriteLine("------ Resultado ------");
            Console.WriteLine("Você digitou:");
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(ch);
            Console.WriteLine("Split:");
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
