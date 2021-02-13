using System;
using System.Globalization;

namespace Largura_e_Comprimento
{
    class Program
    {
        static void Main(string[] args)
        {

            double largura, comprimento, precoMetroQuadrado, area, preco;

            Console.WriteLine();
            Console.Write("Digite a Largura : ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Digite o Comprimento : ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.Write("Digite a Preço do metro quadrado : ");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;

            preco = area * precoMetroQuadrado;

            Console.WriteLine();
            Console.WriteLine("Area = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Preço = " + preco.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
