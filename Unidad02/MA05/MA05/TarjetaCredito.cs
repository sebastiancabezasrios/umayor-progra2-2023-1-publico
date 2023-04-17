using System;
namespace MA05
{
	public class TarjetaCredito:Tarjeta
	{
		private string nombreTarjeta;
		private int cupo;
		private int consumo;

		public TarjetaCredito()
		{
		}

		public bool comprar(int _valor)
		{
			if ((cupo - consumo) <= _valor)
			{
				consumo -= _valor;
				return true;
			}
			return false;
		}

		public bool pagarTarjeta(int _monto)
		{
			if (_monto <= consumo)
			{
				consumo -= _monto;
				return true;
			}
			return false;
		}
	}
}

