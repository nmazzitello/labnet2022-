using Act5.Model;
using Act5.Model.Extra;
using Act5_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2022_Act5_Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            Screen scr = new Screen();
            string opcion="c", idAbuscar;
            CustomersLogic cl = new CustomersLogic();
            ProductsLogic pl = new ProductsLogic();

            Customers c = new Customers();
            Products p = new Products();

            List<Products> listaP = new List<Products>();
            List<Customers> listaC = new List<Customers>();

            do
            {
                Console.Clear();
                opcion = scr.Welcome();
                Console.Clear();

                switch (opcion)
                {
                    case "X":
                        return;

                    case "a":
                        idAbuscar = scr.Ejercicio1();

                        c = cl.BuscarCliente(idAbuscar);
                        scr.MostrarEjercicio1(c);
                        break;

                    case "b":
                        listaP= pl.ProductosSinStock();
                        scr.MostrarEjercicio2(listaP);
                        break;

                    case "c":
                        listaP = pl.ProductosSinStockYmayorTres();
                        scr.MostrarEjercicio3(listaP);
                        break;

                    case "d":
                        listaC = cl.BuscarClienteDeWA();
                        scr.MostrarEjercicio4(listaC);
                        break;

                    case "e":
                        p= pl.PrimerElementoOnulo();
                        scr.MostrarEjercicio5(p);
                        break;

                    case "f":
                        List<String> nombres = new List<string>();
                        nombres = cl.TraerNombreClientes();
                        scr.MostrarEjercicio6(nombres);
                        break;

                    case "g":
                        listaC = cl.TraerWaYfecha();
                        scr.MostrarEjercicio7(listaC);
                        break;

                    case "h":
                        listaC = cl.TraerPrimerosTres();
                        scr.MostrarEjercicio8(listaC);
                        break;

                    case "i":
                        listaP = pl.ProductosOrdenadosPorNombre();
                        scr.MostrarEjercicio9(listaP);
                        break;

                    case "j":
                        listaP = pl.ProductosOrdenadosPorUnidadesStock();
                        scr.MostrarEjercicio10(listaP);
                        break;

                    case "k":
                        scr.NoLlegue();
                        break;

                    case "l":
                        p = pl.PrimerElemento();
                        scr.MostrarEjercicio12(p);
                        break;

                    case "m":
                        scr.NoLlegue();
                        break;
                }
            }while (!opcion.Equals("x"));
            
        }
    }
}
