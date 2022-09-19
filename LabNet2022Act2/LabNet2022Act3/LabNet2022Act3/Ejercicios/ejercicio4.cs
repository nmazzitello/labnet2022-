using LabNet2022Act3.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022Act3.Ejercicios
{
    public class ejercicio4
    {
        public ejercicio4()
        {

        }

        public void Punto4()
        {
            try
            {
                throw new Ejercicio4Exception();
            }
            catch (Ejercicio4Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Tipo: " + e.GetType().Name);
                Console.WriteLine("PROCESO FINALIZADO.Presionar ENTER para continuar");
                Console.ReadKey();
            }
        }
    }
}
