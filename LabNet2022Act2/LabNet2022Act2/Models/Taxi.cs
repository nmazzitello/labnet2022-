using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022Act2.Models
{
    public class Taxi: TransportePublico
    {
        public Taxi()
        {
            tipo = 2;
        }

        public Taxi(int cantidadPasajeros)
        {
            tipo = 2;
            pasajeros = cantidadPasajeros;
        }
    }
}
