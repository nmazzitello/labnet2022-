using Actividad4_EF.Logic;
using Actividad4_EF.Models;
using LabNet2022_Actividad4_EF.Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022_Actividad4_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            Screen scn = new Screen();
            int opt, id;
            Exercise1 e1= new Exercise1();
            Exercise2 e2= new Exercise2();

            do
            {
                scn.Welcome();

                opt = Int32.Parse(Console.ReadLine());
                Console.Clear();

                switch (opt)
                {
                    case 0:
                        return;
                        break;

                    case 1:
                        e1.ListarExportadores();
                        break;

                    case 2:
                        e1.ListarTerritorios();
                        break;

                    case 3:
                        Shippers shi = new Shippers();
                        shi = scn.addShipper();
                        e2.Agregar(shi);
                        break;

                    case 4:
                        e1.ListarExportadores();
                        Shippers shi2 = new Shippers();
                        shi2 = scn.updateShipper();
                        e2.Modificar(shi2);
                        break;

                    case 5:
                        e1.ListarExportadores();
                        id =scn.deleteShipper();
                        e2.Eliminar(id);
                        break;

                    default:
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine("Presionar ENTER para continuar");
                Console.ReadKey();
                Console.Clear();
            } while (opt != 0);
        }
    }
}
