using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EditorHTML
{
    public class Viwer
    {
        public static void Show(string text)
        { 
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Modo Visualizador:");

            Replace(text);
            Console.WriteLine("===========");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s@strong[`{{]*>(.*)");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                { 
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                    words[i].Substring
                    (
                       words[i].IndexOf('>') + 1, 
                       (
                           (words[i].LastIndexOf('<') -1) -
                           words[i].LastIndexOf('>')
                        )
                      )
                    );
                    Console.Write(" ");
                } 
                else
                    {
                        Console.ForegroundColor= ConsoleColor.Black;
                        Console.Write(words[i]);
                        Console.Write(" ");
                    }
            }
        }
    }
}
