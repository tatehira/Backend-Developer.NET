namespace AulaArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa();
        }

        static void Arrays() //Vetor - Lista
        {                       //Posicoes
            var meuArray = new int[5]{1, 2, 3, 4, 5 };
            meuArray[0] = 12; // O array compoe com new, tipo e a quantidade de indices   

        }

        static void Empresa()
        {
            var funcionarios = new Funcionario[1];

            funcionarios[0] = new Funcionario(){ Id = 2023, Name = "Nick", Apelido = "O brabo"};

            Console.WriteLine(funcionarios);
        }

        struct Funcionario
        {
            public int Id { get; set;}
            public string Name { get; set;}
            public string Apelido { get; set;}
        }
    }
}