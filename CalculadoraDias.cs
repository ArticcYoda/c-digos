using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a primeira data (dd/MM/yyyy): ");
            DateTime dataInicial = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda data (dd/MM/yyyy): ");
            DateTime dataFinal = DateTime.Parse(Console.ReadLine());

            TimeSpan diferenca = dataFinal - dataInicial;
            int dias = (int)diferenca.TotalDays;

            Console.WriteLine($"A diferença entre as datas é de {dias} dias.");
    }
}