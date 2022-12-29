/*Exemplos para saída de dados Aula C#*/

using System;
using System.Globalization; /*para poder usar o CultureInfo.InvariantCulture*/

namespace Saida{
    class Program{
        static void Main(string[] args){

            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom dia"); /*não tem quebra de linha*/
            Console.WriteLine("Boa tarde"); /*com quebra de linha*/
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(saldo.ToString("F2")); /*para mostrar duas casas decimais apos a virgula*/
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); /*mostra o ponto em vez da virugula*/
            Console.WriteLine(nome);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Exemplo com Placeholder");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais.", nome, idade, saldo);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Exemplo com Interpolacao");
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Exemplo com Concatenacao");
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2") + " reais.");

        }
    }
}