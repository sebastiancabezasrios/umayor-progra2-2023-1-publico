using System;
namespace Modulo03
{
	public class App
	{
		public static void Main(string[] args)
		{
			RUT rut = new RUT("222.333-1");
			RUT rut2 = new RUT("1122233a-1");
			RUT rut3 = new RUT("11222333-P");
			RUT rut4 = new RUT("11222333-K");
			RUT rut5 = new RUT(27962409);
			RUT rut6 = new RUT(11111111);
			Console.WriteLine(rut.getRut());
            Console.WriteLine(rut2.getRut());
            Console.WriteLine(rut3.getRut());
            Console.WriteLine(rut4.getRut());
            Console.WriteLine(rut5.ToString());
            Console.WriteLine(rut6.ToString());

            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
            Console.WriteLine("The current date is {0}", date);

			Fecha f1 = new Fecha("01/01/2000");
			Console.WriteLine( "el año " + f1.Year + " bisiesto?: " + f1.esBisiesto());
        }
    }
}