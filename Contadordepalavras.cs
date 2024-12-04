using System;

namespace ContarPalavras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            // Dividir a frase em palavras usando espaços como separadores
            string[] palavras = frase.Split(' ');

            // Contar o número de palavras (ignora palavras vazias)
            int numeroDePalavras = palavras.Length;

            Console.WriteLine($"A frase tem {numeroDePalavras} palavras.");
        }
    }
}