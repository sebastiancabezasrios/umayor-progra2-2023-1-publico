using System;
namespace EjercicioVentasOnline
{
	public class App
	{
		public static void Main(String[] args)
		{
			Tienda tienda = new Tienda(1, "Tiendita");

			List<Articulo> listaArticulos = new List<Articulo>();
			List<Cliente> listaClientes = new List<Cliente>();
			List<Vendedor> listaVendedores = new List<Vendedor>();

			listaArticulos.Add(new Articulo(1, "123", "Polera Hombre", "S", 1990, 10));
            listaArticulos.Add(new Articulo(2, "234", "Polera Hombre", "M", 1990, 10));
            listaArticulos.Add(new Articulo(3, "345", "Polera Hombre", "L", 1990, 10));
            listaArticulos.Add(new Articulo(4, "456", "Polera Hombre", "XL", 1990, 10));

            listaClientes.Add(new Cliente(1, "1-1", "Seba", "Cabezas", "sebastian.cabezas.r@gmail.com"));
			listaVendedores.Add(new Vendedor(1, "1-2", "Sebastian", "Cabezas Rios"));

			//a mostrar los recursos creados 

			Console.WriteLine("Tienda: "+tienda.getNombre());
			Console.WriteLine("*** Clientes ***");
            foreach (var cliente in listaClientes)
			{
				Console.WriteLine(cliente.getNombre()+ " " + cliente.getApellido());
			}
            Console.WriteLine("");

            Console.WriteLine("*** Vendedores ***");
            foreach (var vendedor in listaVendedores)
            {
                Console.WriteLine(vendedor.getNombre() + " " + vendedor.getApellido());
            }
            Console.WriteLine("");
        }
	}
}

