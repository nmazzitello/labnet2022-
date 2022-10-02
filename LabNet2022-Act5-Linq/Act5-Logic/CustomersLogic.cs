using Act5.Data;
using Act5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act5_Logic
{
    public class CustomersLogic
    {
        private readonly NorthwindDbContext _context;

        public CustomersLogic()
        {
            _context = new NorthwindDbContext();
        }

        public Customers BuscarCliente(string idCustomer)
        {
            Customers c = new Customers();

            var cliente = from customers in _context.Customers
                          where customers.CustomerID == idCustomer
                          select customers;

            foreach (var item in cliente)
            {
                c = item;
                
            }
            return c;
        }

        public List<Customers> BuscarClienteDeWA()
        {
            List<Customers> lista = new List<Customers>();
            Customers c = new Customers();

            var cliente = _context.Customers.Where(m => m.Region.Equals("WA"));

            foreach (var item in cliente)
            {
                lista.Add(item);

            }
            return lista;
        }

        public List<string> TraerNombreClientes()
        {
            List<string> nombres = new List<string>();

            var lista = from cliente in _context.Customers
                        select cliente;

            foreach (var item in lista)
            {
                nombres.Add(item.ContactName);
            }

            return nombres;

        }

        public List<Customers> TraerWaYfecha()
        {
            Customers c = new Customers();
            List<Customers> lst = new List<Customers>();

            DateTime fechaIndicada = DateTime.Parse("1997-01-01 00:00:00");

            var lista = from cliente in _context.Customers
                        join ordenes in _context.Orders
                        on cliente.CustomerID equals ordenes.CustomerID
                        where (cliente.Region.Equals("WA") & ordenes.OrderDate > fechaIndicada)
                        select cliente;

            foreach (var item in lista)
            {
                lst.Add(item);
            }

            Console.ReadKey();
            return lst;
        }

        public List<Customers> TraerPrimerosTres()
        {
            List<Customers> lista = new List<Customers>();

            var elementos = _context.Customers.Where(c => c.Region.Equals("WA")).Take(3);

            foreach (var item in elementos)
            {
                lista.Add(item);
            }
            return lista;
        }
    }
}
