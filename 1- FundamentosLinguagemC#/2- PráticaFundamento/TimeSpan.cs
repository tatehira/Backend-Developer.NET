using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeZone();
        }

        static void TimeZone()
        {
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            //Criar um timespan com hora, min e seg
            var TimeSpanHoraMinSeg = new TimeSpan(5, 12, 5);
            Console.WriteLine(TimeSpanHoraMinSeg);

            var TimeSpanDiaHoraMinSeg = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(TimeSpanDiaHoraMinSeg);

            //Calulo 
            Console.WriteLine(TimeSpanHoraMinSeg - TimeSpanDiaHoraMinSeg);
            Console.WriteLine(TimeSpanDiaHoraMinSeg.Days);
            Console.WriteLine(TimeSpanDiaHoraMinSeg.Add(new TimeSpan(12, 0, 0)));
        }

        static void Meses()
        {
            //Exibe o total de dias do mes
            Console.WriteLine(DateTime.DaysInMonth(2022, 11));
        }
    }
}