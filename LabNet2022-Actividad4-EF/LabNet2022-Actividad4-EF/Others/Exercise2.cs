using Actividad4_EF.Logic;
using Actividad4_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022_Actividad4_EF.Others
{
    public class Exercise2
    {
        public Exercise2()
        {

        }

        public void Agregar(Shippers shi)
        {
            ShippersLogic sl = new ShippersLogic();
            bool resultado;
            resultado= sl.Add(shi);

            if (resultado)
            {
                Console.WriteLine("AGREGADO CON EXITO");
            }
            else
            {
                Console.WriteLine("ERROR!");
            }
        }

        public void Modificar(Shippers shi)
        {
            ShippersLogic sl = new ShippersLogic();
            bool resultado;
            resultado = sl.Update(shi);

            if (resultado)
            {
                Console.WriteLine("MODIFICADO CON EXITO");
            }
            else
            {
                Console.WriteLine("ERROR!");
            }
        }

        public void Eliminar(int id)
        {
            ShippersLogic sl = new ShippersLogic();
            bool resultado;

            resultado = sl.Delete(id);

            if (resultado)
            {
                Console.WriteLine("ELIMINADO CON EXITO");
            }
            else
            {
                Console.WriteLine("ERROR!");
            }

        }
    }
}
