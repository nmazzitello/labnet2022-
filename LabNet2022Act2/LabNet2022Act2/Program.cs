using LabNet2022Act2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022Act2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TransportePublico> lista = new List<TransportePublico>();

            for (int i = 1; i < 11; i++)
            {
                if (i < 6)
                {
                    bool result = false;
                    do
                    {
                        Console.WriteLine("Ingrese cantidad de pasajeros para el Omnibus" + i + "(LIMITES --> minimo 1/maximo 100): ");
                        string ingresado = Console.ReadLine();
                        int pasajeros;

                        bool soyNumero;
                        if(soyNumero = int.TryParse(ingresado, out pasajeros))
                        {
                            pasajeros = Int32.Parse(ingresado);
                            if(pasajeros<1 || pasajeros > 100)
                            {
                                Console.WriteLine("Respete LIMITES");
                            }
                            else
                            {
                                Omnibus bus = new Omnibus(pasajeros);
                                lista.Add(bus);
                                result = true;
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("INGRESAR SOLO NUMEROS");
                        }
                    } while (!result);
                    
                }
                else
                {
                    bool result = false;
                    do
                    {
                        Console.WriteLine("Ingrese cantidad de pasajeros para el Taxi" + i + "(LIMITES --> minimo 1/maximo 4): ");
                        string ingresado = Console.ReadLine();
                        int pasajeros;

                        bool soyNumero;
                        if (soyNumero = int.TryParse(ingresado, out pasajeros))
                        {
                            pasajeros = Int32.Parse(ingresado);
                            if (pasajeros < 1 || pasajeros > 4)
                            {
                                Console.WriteLine("Respete LIMITES");
                            }
                            else
                            {
                                Taxi taxi = new Taxi(pasajeros);
                                lista.Add(taxi);
                                result = true;
                            }

                        }
                        else
                        {
                            Console.WriteLine("INGRESAR SOLO NUMEROS");
                        }
                    } while (!result);
                }
            }

            int contador = 1;
            foreach (TransportePublico t in lista)
            {
                if (t.tipo == 1)
                {
                    Console.WriteLine("Omnibus" + contador + ": " + t.pasajeros + " pasajeros");
                }
                else
                {
                    Console.WriteLine("Taxi" + contador + ": " + t.pasajeros + " pasajeros");
                }
                contador++;
            }
            Console.ReadKey();
        }
    }
}
