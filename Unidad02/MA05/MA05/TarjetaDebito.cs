using System;
namespace MA05
{
	public class TarjetaDebito : Tarjeta
	{
		private int saldo;

		public TarjetaDebito():base()
		{
			saldo = 0;
		}

		public TarjetaDebito(int _saldo) : base()
        {
			saldo = _saldo;
        }

		public int getSaldo()
		{
			return saldo;
		}

        public bool pagar(int _valor)
		{
			if (saldo <= _valor)
			{
				//saldo = saldo - valor;
				saldo -= _valor;
				return true;
			}
			return false;
		}

		public bool depositar(int _monto)
		{
			//saldo = saldo + monto;
			saldo += _monto;
			return true;
		}
	}
}

