namespace EstudoMetodos {
    class program
    {
        //Método Principal, onde somente aqui é executado o código.
        static void Main(String[] args)
        {
            MetodoEstudo();

            string Nome = Nomes("Nick ", "Tatehira", 22);

            Console.WriteLine(Nome);
        }

        //Método especifico com apenas uma finalidade
        static void MetodoEstudo()
        {
            Console.WriteLine("C # é top! ");
        }

        // Metodo com tipo primitivo STRING e de nome Nome, passando como parametro duas variaveis Strings Vazias podendo ser preenchidas
        static string Nomes (string Nome, string Sobrenome, int idade) // Se colocar um valor para a idade já no método, ele não dá erro na função. Pois é obrigatóri retornar um valor
        {
            return Nome + Sobrenome;
        }
    }
}
