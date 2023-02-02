using System;

namespace EditorHTML
{
	public static class Menu
	{
		public static void Show()
		{
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.Black;
			Console.ForegroundColor = ConsoleColor.Red;

			DrawScreen();
			WriteOptions();

			var option = short.Parse(Console.ReadLine());
			HandleMenuOption(option);
		}

        #region Fazendo a box de menu
        public static void DrawScreen()
		{
            Console.Write("+");
			for (int i = 0; i <= 30; i++)
			{
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

			for (int lines = 0; lines <= 10; lines++)
			{
                Console.Write("|");

                for (int i = 0; i <= 30; i++)
				{
					Console.Write(" ");
				}

                Console.Write("|");
                Console.Write("\n");
			}

			Console.Write("+");	
			for (int i = 0; i <= 30; i++)
			{
				Console.Write("-");
            }
            Console.Write("+");
		}
        #endregion Fazendo a box de menu

        #region Colocando Informações dentro do menu
        public static void WriteOptions()
        {
			// Coloca um cursor na Coluna x e linha y
            Console.SetCursorPosition(3, 2);
			Console.WriteLine("EDITOR HTML");

			Console.SetCursorPosition(3, 3);
			Console.WriteLine("=====================");

			Console.SetCursorPosition(3, 4);
			Console.WriteLine("Selecione uma opção abaixo!");

			Console.SetCursorPosition(3, 6);
			Console.WriteLine("1 - Novo Arquivo!");

			Console.SetCursorPosition(3, 7);
			Console.WriteLine("2 - Abrir Arquivo!");

			Console.SetCursorPosition(3, 8);
			Console.WriteLine("3 - Sair do Arquivo!");

			Console.SetCursorPosition(3, 9);
			Console.Write("Opção: ");
		}

        #endregion Colocando Informações dentro do menu

        #region Manipulando Menu
        public static void HandleMenuOption(short option)
		{
			switch (option)
			{
				case 1: Editor.Show(); break;
				case 2: Console.Write("View"); break;
				case 0:
					{
						Console.Clear();
						Environment.Exit(0);
						break;
					}
					default: Show(); break;	
			}
		}

        #endregion Manipulando Menu
    }
}