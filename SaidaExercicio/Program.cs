using System;
using System.Globalization;

namespace SaidaExercicio{
    class Program{
        static void Main(string[] args){

            string prod1 = "Computador";
            string prod2 = "Mesa de escritório";

            byte idade = 30;
            int cod = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.Write("Produto:");
            Console.WriteLine($"{prod1}, cujo preço é ${preco1:F2}");
            Console.WriteLine($"{prod2}, cujo preço é ${preco2:F2}");
            Console.WriteLine(" ");
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + cod + " e gênero: " + genero);
            Console.WriteLine(" ");
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondado com 3 casas decimais: " + medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}