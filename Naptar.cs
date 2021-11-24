using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBVGD1_Feleves_Feladat_SZTF2
{
    class Naptar
    {
        
        public Lista<Teendo> teendoLista = new Lista<Teendo>();
        private int index = 0;
        private Teendo[] teendokTomb;

        public Lista<Teendo> segedLista = new Lista<Teendo>();

        public void TeendoHozzaAdas(Teendo teendo)
        {
            segedLista.Add(teendo);
            index = 0;
            teendoLista = new Lista<Teendo>();

            teendokTomb = new Teendo[segedLista.Count()];
            foreach (var item in segedLista)
            {
                teendokTomb[index] = item;
                index++;
            }
            
            if (teendokTomb.Length >1)
            {
                TeendoRendezés(ref teendokTomb);
            }
            for (int i = 0; i < teendokTomb.Length; i++)
            {
                teendoLista.Add(teendokTomb[i]);
               
            }
            
   
        }

        public void TeendoRendezés(ref Teendo[] teendokTomb)
        {
            for (int i = 0; i < teendokTomb.Length-1; i++)
            {
                for (int j = i+1; j < teendokTomb.Length; j++)
                {
                    if (teendokTomb[i].prioritas > teendokTomb[j].prioritas)
                    {
                        var tmp = teendokTomb[i];
                        teendokTomb[i] = teendokTomb[j];
                        teendokTomb[j] = tmp;
                    }
                }
            }
        }



    }
}
