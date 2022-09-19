using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022Act3.Ejercicios
{
    public class ejercicio3
    {
        public ejercicio3()
        {
        }

        public void Punto3()
        {
            try
            {
                throw new Exception();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message );
                Console.WriteLine("Tipo: " + e.GetType().Name);
                Console.WriteLine("PROCESO FINALIZADO.Presionar ENTER para continuar");
                Console.ReadKey();
            }
        }
    }
}
