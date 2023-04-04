using System;
namespace Ejemplos
{
	public class App
	{
		public static void Main()
		{
			Console.WriteLine("Ejemplos");
			Cuenta c1 = new Cuenta();
			Console.WriteLine(c1.ToString());

			Cuenta c2 = new Cuenta(123123, 1000);
            Console.WriteLine(c2.ToString());

            Cuenta c3 = new Cuenta(321321, 5000);
            Console.WriteLine(c3.ToString());

            Cliente cl1 = new Cliente("Antonio Banderas");
			Console.WriteLine(cl1.ToString());

			cl1.listaCuentas.Add(c1);
            cl1.listaCuentas.Add(c2);
            cl1.listaCuentas.Add(c3);

			cl1.Nombre = "Hulk";
			//cl1.listaCuentas[0].Saldo = 10000m;
			cl1.listaCuentas[0].depositar(10m);
			cl1.listaCuentas[0].depositar(10m);
            Console.WriteLine("Saldo de la cuenta: " + cl1.listaCuentas[0].Saldo);
            decimal giro = 21m;
			Console.WriteLine("Deseo Girar $" + giro+ ": Resultado: " +cl1.listaCuentas[0].girar(giro));
			Console.WriteLine("Saldo de la cuenta: " + cl1.listaCuentas[0].Saldo);
        }
    }
}

