using System;
using System.Globalization;

namespace Conversor.de.Moeda
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double valor, valorConvertido;
            int opcao;
            

            Console.WriteLine("Digite o valor a ser convertido; ");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Opcao 1 -Converter de real para dola, Opcao 2-Converter de dolar para real");
            opcao = int.Parse(Console.ReadLine());
           
            if(opcao <= 1)
            {
                valorConvertido =valor / 5.39;
            }
            else
            {
                valorConvertido = valor * 5.39 ;
            }

            Console.WriteLine("Valor convertido: "+valorConvertido.ToString("F2", CI)); 







        }
    }
}
