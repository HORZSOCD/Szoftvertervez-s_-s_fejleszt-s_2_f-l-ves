using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBVGD1_Feleves_Feladat_SZTF2
{
    class NincsIlyenTeendoException : Exception
    {
        public NincsIlyenTeendoException(string message) : base(message)
        {

        }
    }
}
