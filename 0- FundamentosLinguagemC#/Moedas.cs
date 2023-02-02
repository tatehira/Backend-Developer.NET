using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            Moedas();
            math();
        }

        static void Moedas()
        {
            // É recomendado usar Decimal para trabalhar com moedas
            decimal valor = 1000.25m;
            Console.WriteLine(valor.ToString("C",//C Aparece o sifrão
                CultureInfo.CreateSpecificCulture("pt-BR")));
        }

        static void math()
        {
            decimal d = 10.090m;
            Moedas();
            //Arredondamento de valores
            Console.WriteLine(Math.Round(d));//Corta o ponto flutuante
            Console.WriteLine(Math.Floor(d)); //Arredonda pra tras
            Console.WriteLine(Math.Ceiling(d));//Arredonda pra cima
        }
    }
}