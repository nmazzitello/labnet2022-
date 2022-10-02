using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act5.Model.Extra
{
    public class Screen
    {
        private string opcion;
        private int contador=1;

        public Screen()
        {

        }

        public string Welcome()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("A- Ejercicio 1- Query para devolver objeto customer");
            Console.WriteLine("B- Ejercicio 2- Query para devolver todos los productos sin stock");
            Console.WriteLine("C- Ejercicio 3- Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad");
            Console.WriteLine("D- Ejercicio 4- Query para devolver todos los customers de la Región WA");
            Console.WriteLine("E- Ejercicio 5- Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789");
            Console.WriteLine("F- Ejercicio 6- Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.");
            Console.WriteLine("G- Ejercicio 7- Query para devolver Join entre Customers y Orders donde los customers sean de la Región WA y la fecha de orden sea mayor a 1 / 1 / 1997.");
            Console.WriteLine("H- Ejercicio 8- Query para devolver los primeros 3 Customers de la  Región WA");
            Console.WriteLine("I- Ejercicio 9- Query para devolver lista de productos ordenados por nombre");
            Console.WriteLine("J- Ejercicio 10- Query para devolver lista de productos ordenados por unit in stock de mayor a menor.");
            Console.WriteLine("K- Ejercicio 12- Query para devolver las distintas categorías asociadas a los productos");
            Console.WriteLine("L- Ejercicio 12- Query para devolver el primer elemento de una lista de productos");
            Console.WriteLine("M- Ejercicio 13- Query para devolver los customer con la cantidad de ordenes asociadas");
            Console.WriteLine("---------------------------------------------------------------------------------------------------");
            Console.WriteLine("X- SALIR");
            Console.WriteLine();
            Console.WriteLine("Presionar la letra del ejercicio correspondiente" );
            Console.WriteLine();
            opcion = Console.ReadLine();
            return opcion;
        }

        public string Ejercicio1()
        {
            Console.WriteLine("Ingrese id de cliente");
            string idCLi = Console.ReadLine();
            return idCLi;
        }

        public void MostrarEjercicio1 (Customers c)
        {
            Console.WriteLine("Cliente: {0}, nombre compañia: {1}, nombre contacto: {2}, rol contacto: {3}, direccion: {4},ciudad: {5}," +
                " region: {6}, CP: {7}, pais: {8}, telefono: {9}, fax: {10}", c.CustomerID, c.CompanyName, c.ContactName, c.ContactTitle, c.Address,
                c.City, c.Region, c.PostalCode, c.Country, c.Phone, c.Fax);

            Console.WriteLine();
            Console.Write("Presiona ENTER para continuar.");
            Console.ReadKey();
        }

        public void MostrarEjercicio2(List<Products> lista)
        {
            Console.WriteLine("Productos sin stock: ");
            Console.WriteLine("");

            foreach (var item in lista)
            {
                Console.WriteLine(contador + "- " + item.ProductName);
                contador++;
            }

            Console.WriteLine("");
            Console.Write("Presiona ENTER para continuar.");
            contador = 1;
            Console.ReadKey();
        }

        public void MostrarEjercicio3(List<Products> lista)
        {
            Console.WriteLine("Productos sin stock y con precio superior a $3: ");
            Console.WriteLine("");

            foreach (var item in lista)
            {
                Console.WriteLine(contador +"- "+item.ProductName);
                contador++;
            }

            Console.WriteLine("");
            Console.Write("Presiona ENTER para continuar.");
            contador = 1;
            Console.ReadKey();
        }

        public void MostrarEjercicio4(List<Customers> lista)
        {
            foreach (var c in lista)
            {
                Console.WriteLine(contador+"- Cliente: {0}, nombre compañia: {1}, nombre contacto: {2}, rol contacto: {3}, direccion: {4},ciudad: {5}," +
                " region: {6}, CP: {7}, pais: {8}, telefono: {9}, fax: {10}", c.CustomerID, c.CompanyName, c.ContactName, c.ContactTitle, c.Address,
                c.City, c.Region, c.PostalCode, c.Country, c.Phone, c.Fax);
                contador++;
            }
            

            Console.WriteLine();
            Console.Write("Presiona ENTER para continuar.");
            contador = 1;
            Console.ReadKey();

        }

        public void MostrarEjercicio5(Products p)
        {
            if (p == null)
            {
                Console.WriteLine("No se encuentra ese producto.");
            }
            else
            {
                Console.WriteLine("Producto: "+ p.ProductID + "- Codigo Prodcuto: " + p.ProductName);
            }

            Console.WriteLine();
            Console.Write("Presiona ENTER para continuar.");
            Console.ReadKey();
        }

        public void MostrarEjercicio6(List<string> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(contador+"- Cliente en mayuscula: " + item.ToUpper() + "- en minuscula: "+item.ToLower());
                contador++;
            }

            Console.WriteLine();
            Console.Write("Presiona ENTER para continuar.");
            contador = 1;
            Console.ReadKey();
        }

        public void MostrarEjercicio7(List<Customers> lista)
        {
            foreach (var item in lista)
            {
                contador++;
            }
            Console.WriteLine("Hay " + contador + " de registros!");

            Console.WriteLine();
            Console.Write("Presiona ENTER para continuar.");
            contador = 1;
            Console.ReadKey();
        }

        public void MostrarEjercicio8(List<Customers> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(contador+ " Cliente: "+ item.CompanyName);
                contador++;
            }
            
            Console.WriteLine();
            Console.Write("Presiona ENTER para continuar.");
            contador = 1;
            Console.ReadKey();
        }

        public void MostrarEjercicio9(List<Products> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(contador + "- Nombre Producto: " + item.ProductName);
                contador++;
            }

            Console.WriteLine();
            Console.Write("Presiona ENTER para continuar.");
            contador = 1;
            Console.ReadKey();
        }

        public void MostrarEjercicio10(List<Products> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(contador + "- Nombre Producto: " + item.ProductName + "- STOCK: "+ item.UnitsInStock);
                contador++;
            }

            Console.WriteLine();
            Console.Write("Presiona ENTER para continuar.");
            contador = 1;
            Console.ReadKey();
        }

        public void MostrarEjercicio12(Products p)
        {
            Console.WriteLine("Primer Producto: " + p.ProductName);
                
            Console.WriteLine();
            Console.Write("Presiona ENTER para continuar.");
            Console.ReadKey();
        }

        public void NoLlegue()
        {
            Console.WriteLine("Me confie con el tiempo y no llegue");
        }
    }
}
