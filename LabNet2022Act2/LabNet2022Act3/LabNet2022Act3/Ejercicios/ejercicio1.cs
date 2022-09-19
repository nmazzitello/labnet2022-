using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022Act3.Ejercicios
{
    public class ejercicio1
    {
        public ejercicio1()
        {
        }

        public void Punto1()
        {
            try
            {
                Console.WriteLine("Ingrese primer numero:");
                string opc = Console.ReadLine();
                Console.WriteLine("Ingrese segundo numero:");
                string opc2 = Console.ReadLine();

                int num1, num2;
                num1 = Int32.Parse(opc);
                num2 = Int32.Parse(opc2);


                float resultado = num1 / num2;
                Console.WriteLine("El resultado es: " + resultado);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("PROCESO FINALIZADO.Presionar ENTER para continuar");
                Console.ReadKey();
            }
        }
    }
}
