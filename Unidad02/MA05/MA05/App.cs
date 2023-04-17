using System;
namespace MA05
{
	public class App
	{
		public static void Main()
		{
			Tarjeta t1 = new Tarjeta(1, 123, "Mayor");
			Console.WriteLine("Nombre del banco de la tarjeta 1: " + t1.getNombreBanco());
			//instanciar un objeto que hereda de Tarjeta
			TarjetaDebito td1 = new TarjetaDebito(2, 234, "Mayor Bank", 1000);
            Console.WriteLine("Nombre del banco de la tarjeta td1: " + td1.getNombreBanco());

        }
    }
}

