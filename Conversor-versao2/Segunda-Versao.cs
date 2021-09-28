using System;
using System.Globalization;
 

namespace Segunda_versao
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            double valor, valorConvertido;
            int opcao;

            Console.WriteLine("BEM VINDO!");

            Console.WriteLine("Opcao 1- Dolar to Real");
            Console.WriteLine("Opcao 2-Real to Dolar");
            Console.WriteLine("Opcao 3-Real to Libra");
            Console.WriteLine("Opcao 4-Libra to Real");
            Console.WriteLine("Qual opção voce Deseja?");
            opcao =int.Parse(Console.ReadLine());
            Console.WriteLine("Qual valor?");
            valor = int.Parse(Console.ReadLine());

            if (opcao==1)
            {
                valorConvertido = valor * 5.39;
                Console.WriteLine("Valor convertido :  "+valorConvertido.ToString("F2")+" Reais");
            }
            else if (opcao == 2)
            {
                valorConvertido = valor / 5.39;
                Console.WriteLine("Valor convertido :  " + valorConvertido.ToString("F2") + " Dolares");
            }
            if (opcao == 3)
            {
                valorConvertido = valor / 7.36;
                Console.WriteLine("Valor convertido :  " + valorConvertido.ToString("F2") + " Libras");
            }
            else if (opcao == 4)
            {
                valorConvertido = valor * 7.36;
                Console.WriteLine("Valor convertido :  " + valorConvertido.ToString("F2") + " Reais");
            }
        }
    }
}
