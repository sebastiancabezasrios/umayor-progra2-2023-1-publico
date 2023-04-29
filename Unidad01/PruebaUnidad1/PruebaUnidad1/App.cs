using System;
namespace PruebaUnidad1
{
	public class App
	{
		public static void Main()
		{
			Kiosko kioskoFile = new Kiosko(5, 5, 5, "pedidos.txt");
            Console.WriteLine(kioskoFile.ToString());
			Console.WriteLine(kioskoFile.mostrarSinStock());
            Console.WriteLine(kioskoFile.mostrarPedidosFactiles("alta".Trim().ToUpper()));

        }
    }
}

