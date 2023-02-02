using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args)
        {
            var data1 = new DateTime(/*ano, mes, dia, hora, minuto, segundo*/); /*Cria uma data com o parametro passado*/
            var data = DateTime.Now; // Mostra a data atual

            //yyyy->ano | mm->mes | dd->dia
            // hh->hora | mm->minuto | ss->segundos
            // modelos pre definitos para usar(:r, s ou u)
            var formatada = string.Format("{0: yyyy/mm/dd - hh:mm:ss}", data);
            Console.WriteLine(formatada);

            //Adicionando valores a data
            Console.WriteLine(data);
            Console.WriteLine(data.AddDays(5));
            Console.WriteLine(data.AddHours(5));

            //Comparação de datas
            if (data.Date == DateTime.Now.Date)
            {
                Console.Write(data);
            }
            Globalization();
            HoraLocal();
        }

        static void Globalization()
        {
            Console.Clear();
            //Formatando o formato da data para determinada região
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", br));
            Console.WriteLine(DateTime.Now.ToString("D", en));
            Console.WriteLine(DateTime.Now.ToString("D", de));
            Console.WriteLine(DateTime.Now.ToString("D", atual));
        }

        static void HoraLocal()
        {
            //Como usar a hora local de acordo com a maquina do cliente
            var dateTime = DateTime.UtcNow;

            Console.WriteLine(dateTime.ToLocalTime());

            //criar uma TimeZone personalizada
            var timezoneAustralia = 
                TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");

            var HoraAustralia =
                TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
        }
    }
}