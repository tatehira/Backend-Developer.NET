using System.Diagnostics;

namespace Cronometro
{ 
    class Program
    {
        static void Main (string[] args)
        {
            Start();
        }

        #region Menu

        #endregion Menu

        #region Start Cronometro
        static void Start()
        {
            int time = 10;
            int CurrentTime = 0;

            while (CurrentTime != time)
            {
                Console.Clear();
                CurrentTime++;
                Console.WriteLine(CurrentTime);
                Thread.Sleep(500); // Faz com que a estrutura ocorra devagar 'durma' 1000 segundos
            }

            Console.Clear();
            Console.Write("StopWacth Finalizado! ");
            Thread.Sleep(1000);
        }

        #endregion Start Cronometro
    }
}