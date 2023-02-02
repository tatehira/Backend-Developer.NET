namespace Cronometro
{
    class Text
    {
        static void Main(string[] args) 
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Escolha uma opção! ");
            Console.WriteLine("1- Abrir arquivo");
            Console.WriteLine("2- Criar um novo arquivo");
            Console.WriteLine("0- Sair");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }

        static void Edit()
        {
            Console.Clear();

            Console.WriteLine("Digite seu texto abaixo:");
            Console.WriteLine("------------------------");
            string texto = "";

            do
            {
                texto += Console.ReadLine(); // escrever tudo em uma linha
                texto += Environment.NewLine; // Cria uma nova linha a cada final de execução
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            // Identifica a tecla pressionada        Identifica a tecla especifica 'esc'

            Save(texto);
        }

        static void Save(string texto)
        {
            Console.Clear();

            Console.WriteLine("Digite o caminho para salvar o arquivo: ");
            var caminho = Console.ReadLine();

            // abre e fecha o arquivo
            using (var file = new StreamWriter(caminho))
            {
                file.Write(texto);
            }

            Console.WriteLine($"Arquivo {caminho} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }

        static void Open()
        {
            Console.Clear();
            Console.WriteLine("Digite o caminho do arquivo para abri-lo:");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string texto = file.ReadToEnd();
                Console.WriteLine(texto);
            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
    }
}