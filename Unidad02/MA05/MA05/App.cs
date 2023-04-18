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
			TarjetaDebito td1 = new TarjetaDebito(1, 234, "Mayor Bank", 1000);
            Console.WriteLine("Nombre del banco de la tarjeta td1: " + td1.getNombreBanco());
            Console.WriteLine("saldo td1: " + td1.getSaldo());
			Console.WriteLine("Transaccion de Depositar?: " + td1.depositar(500));
            Console.WriteLine("saldo td1: " + td1.getSaldo());
			int montoCompra = 500;
			Console.WriteLine("Hacemos una compra de $" + montoCompra + "?: " + td1.pagar(montoCompra));
            Console.WriteLine("saldo td1: " + td1.getSaldo());
			//tarjeta de credito
			TarjetaCredito tc1 = new TarjetaCredito(3, "Seba", 987, 5000, "Soper Bank", 4500);
            Console.WriteLine("Consumo actual: $" + tc1.getConsumo());
            Console.WriteLine("Banco de la tarjeta de credito es: " + tc1.getNombreBanco());

            Console.WriteLine("hacemos una compra por $"+ montoCompra +" y resulto: " + tc1.comprar(montoCompra));
			int montoPago = 5000;
            Console.WriteLine("Consumo $"+tc1.getConsumo()+" hacemos un pago por $" + montoPago + " y resulto: " + tc1.pagarTarjeta(montoPago));
			Console.WriteLine("Consumo actual: $" + tc1.getConsumo());




        }
    }
}

