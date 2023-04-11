using System;
namespace MA04
{
	public class App
	{
		public static void Main()
		{
			const int maximoTrabajadores = 2;
			Ferreteria ferro = new Ferreteria();
			for (int i = 0; i < maximoTrabajadores; i++)
			{
				Console.WriteLine("["+i+"] Ingrese id del Vendedor: ");
				int id = int.Parse(Console.ReadLine());
                Console.WriteLine("[" + i + "] Ingrese nombre del Vendedor: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("[" + i + "] Ingrese Monto Acumulado del Vendedor: ");
				double montoAcumulado = double.Parse(Console.ReadLine());

                Vendedor vendedorAuxiliar = new Vendedor(id, nombre.Trim(), montoAcumulado);
				ferro.agregarVendedor(vendedorAuxiliar);
			}
			//respuesta A en implementacion del metodo nominaVendedores
			ferro.nominaVendedores();
			//respuesta A en implementacion de la funcion
			foreach (Vendedor item in ferro.getNominaVendedores())
			{
				Console.WriteLine("("+item.getId()+") " + item.getNombre());
			}
			//implementacion respuesta b
			Console.WriteLine("Vendedor y monto con mayor venta: " + ferro.getNombreMontoVendedorConMayorVenta());
			//implementacion respuesta c
			Console.WriteLine("Monto total vendido: " + ferro.getMontoTotalVendido());
			//implementacion respuesta d
			double montoDeterminado = 1100;
			Console.WriteLine("Nómina vendedores con ventas inferiores a un monto determinado " + montoDeterminado);
            foreach (Vendedor item in ferro.getNominaVendedoresVentasInferioresA(montoDeterminado))
            {
                Console.WriteLine("- (" + item.getId() + ") " + item.getNombre() + " $" + item.getMontoAcumulado());
            }
			//implementacion respuesta E
			Console.WriteLine("Porcentaje Vendido de " + ferro.getNominaVendedores().First().getNombre() + " es: "+ferro.getPorcentajeVendidoRespectoVentaTotal(ferro.getNominaVendedores().First()) + "%");
			Console.WriteLine("Porcentaje Vendido de " + ferro.getNominaVendedores().First().getNombre() + " es: "+ferro.getPorcentajeVendidoRespectoVentaTotal(ferro.getNominaVendedores().First().getId()) + "%");
			//implementacion respuesta F
			int idVendedor = 1;
			Console.WriteLine("Monto de Comision del Vendedor (" + idVendedor + "): $"+ferro.getMontoComisionVendedorByParametro(idVendedor, 10));
			Console.WriteLine("Monto de Comision del Vendedor (2): $"+ferro.getMontoComisionVendedorByParametro(2, 10));
			//implementacion respuesta G
			string nombreVendedor = "     Ale ".Trim();
			Console.WriteLine("Monto vendido por vendedor [" + nombreVendedor + "] es: $"+ferro.getMontoVendidoByNombre(nombreVendedor));
        }
    }
}
//clases
//vendedor