using System;
namespace EjercicioVentas
{
    public class App
    {
        public static void Main(String[] args)
        {
            //
            Tienda tienda1 = new Tienda(1, "Tiendita");
            Tienda tienda2 = new Tienda(2, "Outlet");

            List<Articulo> listaArticulos = new List<Articulo>();
            List<Cliente> listaClientes = new List<Cliente>();
            List<Vendedor> listaVendedores = new List<Vendedor>();

            listaArticulos.Add(new Articulo(1, "123", "Polera Hombre", "S", 1990, 10, tienda1.getId()));
            listaArticulos.Add(new Articulo(2, "234", "Polera Hombre", "M", 1990, 10, tienda2.getId()));
            listaArticulos.Add(new Articulo(3, "345", "Polera Hombre", "L", 1990, 10, tienda1.getId()));
            listaArticulos.Add(new Articulo(4, "456", "Polera Hombre", "XL", 1990, 10, tienda2.getId()));
            listaArticulos.Add(new Articulo(5, "567", "Polera Mujer", "S", 1490, 10, tienda1.getId()));
            listaArticulos.Add(new Articulo(6, "678", "Polera Mujer", "M", 1490, 10, tienda2.getId()));
            listaArticulos.Add(new Articulo(7, "789", "Polera Mujer", "L", 1490, 10, tienda1.getId()));
            listaArticulos.Add(new Articulo(8, "890", "Polera Mujer", "XL", 1490, 10, tienda2.getId()));

            listaClientes.Add(new Cliente(1, "1-1", "Seba", "Cabezas", "sebastian.cabezas.r@gmail.com"));
            listaClientes.Add(new Cliente(2, "2-2", "Ale", "Rios", "alejandro.rios.c@gmail.com"));
            listaVendedores.Add(new Vendedor(1, "1-2", "Sebastian", "Cabezas Rios", tienda1.getId()));
            listaVendedores.Add(new Vendedor(2, "1-3", "Marcela", "Cabezas Seguel", tienda2.getId()));

            //se simulan ventas
            List<Venta> listaVentas = new List<Venta>();
            listaVentas.Add(new )

            //a mostrar los recursos creados 
            mostrarDataTienda(tienda1, listaArticulos, listaVendedores, listaClientes);
            mostrarDataTienda(tienda2, listaArticulos, listaVendedores, listaClientes);

        }

        private static void mostrarDataTienda(Tienda _tienda, List<Articulo> _listaArticulos, List<Vendedor> _listaVendedores, List<Cliente> _listaClientes)
        {
            Console.WriteLine("= = = Mostrando toda la data = = =");
            Console.WriteLine("Articulos disponibles en [" + _tienda.getNombre().ToUpper() +"]");
            foreach (Articulo item in _tienda.getArticulosTiendaId(_listaArticulos, _tienda.getId()))
            {
                Console.WriteLine("- Id : [" + item.getId() + "] Articulo : [" + item.getNombre() + "] Talla : ["+item.getTalla()+"] Stock: [" + item.getStock() + "] Precio : $ " + item.getPrecio());
            }
            Console.WriteLine("Vendedores que trabajan en [" + _tienda.getNombre().ToUpper() + "]");
            foreach (Vendedor item in _tienda.getVendedoresTiendaId(_listaVendedores, _tienda.getId()))
            {
                Console.WriteLine("- ["+item.getRut()+"] " + item.getNombre() + " " + item.getApellido() + " ");
            }
        }
    }
}

