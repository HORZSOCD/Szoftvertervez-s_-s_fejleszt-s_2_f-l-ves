using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBVGD1_Feleves_Feladat_SZTF2
{
    abstract class Teendo:ITeendo
    {
        public string Teendo_megnevezes;
        public TimeSpan idoTartam { get; set; }
        public int prioritas { get; set; }

        public Teendo(string Teendo_megnevezes, TimeSpan idoTartam, int prioritas)
        {
            this.Teendo_megnevezes = Teendo_megnevezes;
            this.idoTartam = idoTartam;
            this.prioritas = prioritas;
            
        }

        
    }

}
