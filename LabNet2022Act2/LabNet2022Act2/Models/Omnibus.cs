using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022Act2.Models
{
    public class Omnibus: TransportePublico
    {
        public Omnibus()
        {
            tipo = 1;
        }

        public Omnibus(int cantPasajeros)
        {
            tipo = 1;
            pasajeros = cantPasajeros;
        }
    }
}
