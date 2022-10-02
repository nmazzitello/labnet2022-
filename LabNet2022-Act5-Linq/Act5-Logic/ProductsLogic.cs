using Act5.Data;
using Act5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act5_Logic
{
    public class ProductsLogic
    {
        private readonly NorthwindDbContext _context;
        public ProductsLogic()
        {
            _context = new NorthwindDbContext();
        }

        public List<Products> ProductosSinStock()
        {
            List<Products> lista = new List<Products>();

            var prod = _context.Products.Where(p => p.UnitsInStock < 1);

            foreach(var item in prod)
            {
                lista.Add(item);
            }

            return lista;
        }

        public List<Products> ProductosSinStockYmayorTres()
        {
            List<Products> lista = new List<Products>();

            var prod = from productos in _context.Products
                       where (productos.UnitsInStock > 0 & productos.UnitPrice > 3)
                       select productos;

            foreach (var item in prod)
            {
                lista.Add(item);
            }

            return lista;
        }

        public Products PrimerElementoOnulo()
        {
            Products p = new Products();

            var primeroOnull = _context.Products.Where(pr => pr.ProductID == 789).FirstOrDefault();

            p = primeroOnull;

            return p;
        }

        public List<Products> ProductosOrdenadosPorNombre()
        {
            List<Products> lista = new List<Products>();

            var nombres = _context.Products.OrderBy(p => p.ProductName);

            foreach (var item in nombres)
            {
                lista.Add(item);
            }

            return lista;
        }

        public List<Products> ProductosOrdenadosPorUnidadesStock()
        {
            List<Products> lista = new List<Products>();

            var nombres = _context.Products.OrderByDescending(p => p.UnitsInStock);

            foreach (var item in nombres)
            {
                lista.Add(item);
            }

            return lista;
        }

        public Products PrimerElemento()
        {
            Products p = new Products();

            var primero = _context.Products.First();

            p = primero;

            return p;
        }
    }
}
