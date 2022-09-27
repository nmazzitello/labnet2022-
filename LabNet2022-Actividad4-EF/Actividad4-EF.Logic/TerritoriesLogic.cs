using Actividad4_EF.Data;
using Actividad4_EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4_EF.Logic
{
    public class TerritoriesLogic
    {
        private readonly DBContext _context;

        public TerritoriesLogic()
        {
            _context = new DBContext();
        }

        public List<Territories> GetAll()
        {
            return _context.Territories.ToList();
        }

    }
}
