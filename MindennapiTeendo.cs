using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBVGD1_Feleves_Feladat_SZTF2
{
    class MindennapiTeendo : Teendo
    {

        public DateTime kezdes;
        public MindennapiTeendo(string Teendo_megnevezes, TimeSpan idoTartam, int prioritas, DateTime kezdes) : base(Teendo_megnevezes, idoTartam, prioritas)
        {
            this.kezdes = kezdes;
        }
    }
}
