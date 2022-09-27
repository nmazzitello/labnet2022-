using Actividad4_EF.Data;
using Actividad4_EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad4_EF.Logic
{
    public class ShippersLogic : IAbmlLogic <Shippers>
    {
        private readonly DBContext _context;

        public ShippersLogic()
        {
            _context = new DBContext();
        }

        public List<Shippers> GetAll()
        {
            return _context.Shippers.ToList();
        }

        public bool Add (Shippers shi)
        {
            try
            {
                _context.Shippers.Add(shi);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            Shippers shi = new Shippers();
            try
            {
                shi = _context.Shippers.Find(id);
                _context.Shippers.Remove(shi);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(Shippers shi)
        {
            try
            {
                var aux = _context.Shippers.Find(shi.ShipperID);
                aux.CompanyName = shi.CompanyName;
                aux.Phone = shi.Phone;

                _context.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
