using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBVGD1_Feleves_Feladat_SZTF2
{
    class VisszateroTeendo : Teendo
    {
        public int hetiRendszeresseg;
        public VisszateroTeendo(string Teendo_megnevezes, TimeSpan idoTartam, int prioritas,int hetiRendszeresseg) : base(Teendo_megnevezes, idoTartam, prioritas)
        {
            this.hetiRendszeresseg = hetiRendszeresseg;
        }
    }
}
