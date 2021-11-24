using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBVGD1_Feleves_Feladat_SZTF2
{
    class EgyszeriTeendo : Teendo
    {
        public DateTime hatarido;
        public EgyszeriTeendo(string Teendo_megnevezes, TimeSpan idoTartam, int prioritas, DateTime hatarido) : base(Teendo_megnevezes, idoTartam, prioritas)
        {
            this.hatarido = hatarido;
        }
    }
}
