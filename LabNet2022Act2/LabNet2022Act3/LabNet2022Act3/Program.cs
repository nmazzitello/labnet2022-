using LabNet2022Act3.Ejercicios;
using LabNet2022Act3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022Act3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string opcion;
            int opcionNum;

            do
            {
                Console.Clear();

                Pantalla pantalla = new Pantalla();
                pantalla.MostrarPantalla();

                opcion = Console.ReadLine();
                opcionNum = Int32.Parse(opcion);
                Console.Clear();

                switch (opcionNum)
                {
                    case 0:
                        return;
                        break;

                    case 1:
                        ejercicio1 ejer = new ejercicio1();
                        ejer.Punto1();
                        break;

                    case 2:
                        ejercicio2 ejer2 = new ejercicio2();
                        ejer2.Punto2();
                        break;

                    case 3:
                        ejercicio3 ejer3 = new ejercicio3();
                        ejer3.Punto3();
                        break;

                    case 4:
                        ejercicio4 ejer4 = new ejercicio4();
                        ejer4.Punto4();
                        break;

                    default:
                        break;
                }
            } while (!salir);

        }
    }
}
