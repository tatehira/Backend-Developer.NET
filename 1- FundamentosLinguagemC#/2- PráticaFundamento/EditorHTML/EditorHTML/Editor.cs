using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Modo Editor:");
            Console.WriteLine("===========");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.AppendLine(Console.ReadLine());
                file.AppendLine(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("===========");
            Console.WriteLine("Deseja salvar o arquivo? ");
            
        }
    }
}
