using System;
using System.Globalization;

namespace EstradaExercicio{
    class Program{
        static void Main(string[] args){

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem sua casa?");
            int quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.WriteLine("Entre com seu último nome, idade e altura (na mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string sNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2]);

            Console.WriteLine(" ");
            Console.WriteLine("----- Resultado -----");
            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco.ToString("F2"));
            Console.WriteLine(sNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));

        }
    }
}
