using System.Diagnostics;

namespace Calculadora
{ 
    class Program
    {
        static void Main (string[] args)
        {
            menu();
        }

        #region Menu Seleção
        static void menu()
        {
            Console.Clear();
            Console.WriteLine("-- MENU DE SELÇÂO ---");
            Console.Write("" +
                "Digite o número: \r\n" +
                "1 - Para Adição (+) \r\n" +
                "2 - Para Multiplicação (x) \r\n" +
                "3 - Para Divisão (/) \r\n" +
                "4 - Para Subtração (-) \r\n" +
                "0 - Para Exerrar p programa \r\n");

           short resposta = short.Parse(Console.ReadLine());
           
            switch (resposta) 
            { 
                case 1: Adicao(); break;
                case 2: Multiplicacao(); break;
                case 3: Divisao(); break;
                case 4: Subtracao();break;
                case 5: break;
                default: menu(); break;
            }
        }

        #endregion Menu Seleção

        #region Calculo Adição
        static void Adicao()
        {
            Console.Clear();

            Console.WriteLine("--- Tela Somas ---");

            Console.Write("Quantos números deseja colocar para a somar? ");
            short QntNumeros = short.Parse(Console.ReadLine());
            Console.Clear();

            float num = 0;
            float soma = 0;
            int cont = 0;

            for (int i = 0; i < QntNumeros; i++)
            {
                Console.Write($"Digite o {i + 1} número para soma: ");
                num = float.Parse(Console.ReadLine());

                soma = soma + num;
                cont++;
            }

            Console.Clear();

            Console.WriteLine($"A soma dos {cont} números digitados é: {soma}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Press ENTER para prosseguir! ");
            Console.ReadKey();

            menu();
        }

        #endregion Calculo Adição

        #region Calculo Multiplicação
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("--- Tela Multiplicação ---");

            Console.Write("Quantos números deseja colocar para a Multiplicar? ");
            short QntNumeros = short.Parse(Console.ReadLine());
            Console.Clear();

            float num = 0;
            float multiplicar = 1;
            int cont = 0;

            for (int i = 0; i < QntNumeros; i++)
            {
                Console.Write($"Digite o {i + 1} número para soma: ");
                num = float.Parse(Console.ReadLine());

                multiplicar = multiplicar * num;
                cont++;
            }

            Console.Clear();

            Console.WriteLine($"A multiplicação dos {cont} números digitados é: {multiplicar}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Press ENTER para prosseguir! ");
            Console.ReadKey();

            menu();  
        }

        #endregion Calculo Multiplicação

        #region Divisão

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("--- Tela Divisão ---");

            Console.Write("Quantos números deseja colocar para a Dividir? ");
            short QntNumeros = short.Parse(Console.ReadLine());
            Console.Clear();

            float num = 0;
            float divisao = 0;
            int cont = 0;

            for (int i = 0; i < QntNumeros; i++)
            {
                Console.Write($"Digite o {i + 1} número: ");
                num = float.Parse(Console.ReadLine());

                divisao = divisao + num;
                cont++;
            }

            float calculo = (divisao / cont);

            Console.Clear();

            Console.WriteLine($"A divisao dos {cont} números digitados é: {calculo}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Press ENTER para prosseguir! ");
            Console.ReadKey();

            menu();
        }

        #endregion Divisão

        #region Subtração

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("--- Tela Subtração ---");

            Console.Write("Digite o 1 número: ");
            float n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2 número: ");
            float n2 = int.Parse(Console.ReadLine());

            float subtracao = (n1 - n2);

            Console.Clear();

            Console.WriteLine($"A Subtração dos números digitados é: {subtracao}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Press ENTER para prosseguir! ");
            Console.ReadKey();

            menu();
        }

        #endregion Subtração

    }
}