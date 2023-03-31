using System;

namespace EjercicioVentas
{
	public class App
	{
		public static void Main(String[] args)
		{
            Tienda tienda1 = new Tienda(1, "Tiendita");
            Tienda tienda2 = new Tienda(2, "Mayor Clotes");

            List<Articulo> listaArticulos = new List<Articulo>();
            List<Cliente> listaClientes = new List<Cliente>();
            List<Vendedor> listaVendedores = new List<Vendedor>();

            //id, codigo, nombre, talla, precio, stock, tiendaId
            listaArticulos.Add(new Articulo(1, "123", "Polera Hombre", "S", 1990, 10, 1));
            listaArticulos.Add(new Articulo(2, "234", "Polera Hombre", "M", 1990, 10, 2));
            listaArticulos.Add(new Articulo(3, "345", "Polera Hombre", "L", 1990, 10, 1));
            listaArticulos.Add(new Articulo(4, "456", "Polera Hombre", "XL", 1990, 10, 2));
            listaArticulos.Add(new Articulo(5, "567", "Polera Mujer", "S", 1990, 10, 1));
            listaArticulos.Add(new Articulo(6, "678", "Polera Mujer", "M", 1990, 10, 2));
            listaArticulos.Add(new Articulo(7, "789", "Polera Mujer", "L", 1990, 10, 1));
            listaArticulos.Add(new Articulo(8, "890", "Polera Mujer", "XL", 1990, 10, 2));
            //id, rut, nombre, apellido, tiendaId
            listaVendedores.Add(new Vendedor(1, "v1-1", "Sebastian", "Cabezas", 1));
            listaVendedores.Add(new Vendedor(2, "v1-2", "Alejandro", "Rios", 2));
            listaVendedores.Add(new Vendedor(3, "v1-3", "Marcela", "Cabezas", 1));
            listaVendedores.Add(new Vendedor(4, "v1-4", "Carolina", "Seguel", 2));
            //id, rut, nombre, apellido, correo
            listaClientes.Add(new Cliente(1, "1-1", "Seba", "Cabezas", "sebastian.cabezas.r@gmail.com"));

        }
	}
}

