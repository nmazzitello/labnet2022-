using Actividad4_EF.Logic;
using Actividad4_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022_Actividad4_EF.Others
{
    public class Exercise1
    {
        public Exercise1()
        {

        }
        public void ListarExportadores()
        {
            ShippersLogic sl = new ShippersLogic();

            List<Shippers> lista= sl.GetAll();

            foreach(var item in lista)
            {
                Console.WriteLine("El exportador " + item.ShipperID + " es " + item.CompanyName + " y su telefono es: " + item.Phone);
            }
        }

        internal void ListarTerritorios()
        {
            TerritoriesLogic tl = new TerritoriesLogic();

            List<Territories> lista = tl.GetAll();

            foreach (var item in lista)
            { 
                Console.WriteLine("El Territorio " + item.TerritoryID + " es " + item.TerritoryDescription.Trim() + " y pertenece a la region: " + item.Region.RegionDescription);
            }
        }
    }

}
