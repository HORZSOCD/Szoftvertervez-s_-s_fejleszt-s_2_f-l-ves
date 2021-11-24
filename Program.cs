using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBVGD1_Feleves_Feladat_SZTF2
{
    class Program
    {
        static void Main(string[] args)
        {
            Naptar naptar = new Naptar();

            naptar.TeendoHozzaAdas(new MindennapiTeendo("napi posta áttekintés",new TimeSpan(0,30,0), 1, new DateTime(2021,11,9,8,0,0)));
            naptar.TeendoHozzaAdas(new EgyszeriTeendo("törvényjavaslat előkészítés", new TimeSpan(0, 30, 0), 100, new DateTime(2021, 11, 9, 8, 0, 0)));
            naptar.TeendoHozzaAdas(new VisszateroTeendo("média megjelenés", new TimeSpan(0, 30, 0), 10, 2));
            
            

           foreach (var item in naptar.teendoLista)
           {
                Console.WriteLine(item.Teendo_megnevezes);
           }



            Console.ReadKey();
        }
    }
}
