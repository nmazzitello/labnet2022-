using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022Act3.Models
{
    public class Pantalla
    {
        public Pantalla()
        {

        }

        public void MostrarPantalla()
        {
            Console.WriteLine("Seleccionar el numero del ejercio a ejecutar: ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1- EXCEPCION GENERICA DIVIDIR POR 0");
            Console.WriteLine("2- EXCEPCION PERSONALIZADA DIVIDIR 0 E INGRESO NO SEA NUMERO");
            Console.WriteLine("3- EXCEPCION FORZADA");
            Console.WriteLine("4- EXCEPCION FORZADA PERSONALIZADA");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("0- SALIR");
            Console.WriteLine("----------------------------------------------");
        }
    }
}
