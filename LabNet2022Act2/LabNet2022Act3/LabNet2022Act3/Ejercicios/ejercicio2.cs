using LabNet2022Act3.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022Act3.Ejercicios
{
    public class ejercicio2
    {
        public ejercicio2()
        {

        }

        public void Punto2()
        {
            try
            {
                Console.WriteLine("Ingrese primer numero:");
                string opc = Console.ReadLine();
                Console.WriteLine("Ingrese segundo numero:");
                string opc2 = Console.ReadLine();

                int num1, num2;
                bool esNumero1 = Int32.TryParse(opc, out num1);
                bool esNumero2 = Int32.TryParse(opc2, out num2);

                if (!esNumero1 || !esNumero2)
                {
                    throw new Exception();
                }

                float resultado =num1 / num2;
                Console.WriteLine("El resultado es: " + resultado);
            }
            
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("World, no se puede dividir por 0" + ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Seguro ingreso una letra o no ingreso nada"); 
            }
            finally
            {
                Console.WriteLine("PROCESO FINALIZADO.Presionar ENTER para continuar");
                Console.ReadKey();
            }
        }
    }
}
