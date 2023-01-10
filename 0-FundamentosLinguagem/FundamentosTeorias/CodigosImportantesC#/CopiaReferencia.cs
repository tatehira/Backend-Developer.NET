namespace AulaReference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de cópia de valores//
            int x = 25;
            int y = x;
            Console.WriteLine(x);
            Console.WriteLine(y);

            //Exemplo de Referencia de valores//
            var Arreio = new string[2];
            Arreio[0] = "Maça";
            Arreio[1] = "Pera";

            // O var ARREIO2 herda todos os resultados que se obter no Arreio, independente de quantos tiver
            var Arreio2 = Arreio;

            Console.WriteLine(Arreio[0]);
            Console.WriteLine(Arreio2[0]);

            Console.WriteLine(Arreio[1]);
            Console.WriteLine(Arreio2[1]);
        }
    }
}