using FsCheck;
using System;

namespace MeuApp
{
    class Program
    {
        var Compras = new Produt (2, "Mouse gamer", 380.90, EProductType.Service);

    }
    struct Produt
    {
        public int Id;

        public string nome;

        public int Valor;

        public EProductType Type;
        enum EProductType
        {
            Product = 1,
            Service = 2,
        }
    }
}
