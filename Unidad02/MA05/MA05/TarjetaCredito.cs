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
        public TarjetaCredito(int _id, string _nombreTarjeta, double _numero, int _cupo, string _nombreBanco, int _consumo) : base(_id, _numero, _nombreBanco)
        {
			nombreTarjeta = _nombreTarjeta;
			cupo = _cupo;
			consumo = _consumo;
        }

        public bool comprar(int _valor)
		{
			if ((cupo - consumo) >= _valor)
			{
				consumo += _valor;
				return true;
			}
			return false;
		}

		public int getConsumo()
		{
			return consumo;
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

