using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022Act2.Models
{
    public abstract class TransportePublico
    {
        public int pasajeros { get; set; }
        public int tipo { get; set; }

        public void Avanzar()
        {
            Console.WriteLine("Estoy avanzando!");
        }

        public  void Detenerse()
        {
            Console.WriteLine("Me estoy deteniendo...");
        }
    }
}
