using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            arrays();
        }

        static void arrays()
        {
            Console.Clear();

            var MeuArray = new Teste[5];
            MeuArray[0] = new Teste();

            Console.WriteLine(MeuArray[0].Id);
            Console.WriteLine(MeuArray[1]);
            Console.WriteLine(MeuArray[2]);
            Console.WriteLine(MeuArray[3]);
            Console.WriteLine(MeuArray[4]);
        }

        struct Teste
        {
            public int Id { get; set; }
        }
    }
}