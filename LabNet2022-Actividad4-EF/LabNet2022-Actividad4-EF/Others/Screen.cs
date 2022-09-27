using Actividad4_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022_Actividad4_EF.Others
{
    public class Screen
    {
        public Screen()
        {

        }

        public void Welcome()
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("1- Para ver los exportadores");
            Console.WriteLine("2- Para ver los territorios");
            Console.WriteLine("3- Agregar exportador");
            Console.WriteLine("4- Editar exportador");
            Console.WriteLine("5- Eliminar exportador");
            Console.WriteLine("----------------------------");
            Console.WriteLine("0- SALIR");
            Console.WriteLine("----------------------------");
        }

        public Shippers addShipper()
        {
            Shippers shi = new Shippers() ;
            Console.WriteLine("Ingrese nombre exportador: ");
            shi.CompanyName = Console.ReadLine();
            Console.WriteLine("Ingrese número de teléfono: ");
            shi.Phone = Console.ReadLine();
            return shi;
        }

        public Shippers updateShipper()
        {
            Shippers shi = new Shippers();
            Console.WriteLine("");
            Console.WriteLine("Seleccione número de exportador para modificar: ");
            shi.ShipperID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nuevo nombre: ");
            shi.CompanyName = Console.ReadLine();
            Console.WriteLine("Ingrese nuevo número de teléfono: ");
            shi.Phone = Console.ReadLine();
            return shi;
        }

        public int deleteShipper()
        {
            int opcion;
            Console.WriteLine("");
            Console.WriteLine("Ingrese el código del exportador a eliminar: ");
            opcion = Int32.Parse(Console.ReadLine());
            return opcion;
        }
    }
}
