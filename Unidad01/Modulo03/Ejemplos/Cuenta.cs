using System;
namespace Ejemplos
{
	public class Cuenta
	{
		private long numero;
		private decimal saldo;

		public Cuenta()
		{
			numero = 0;
			saldo = 0.0m;
		}
        public Cuenta(long _numero)
        {
            numero = _numero;
            saldo = 0.0m;
        }
        public Cuenta(long _numero, decimal _saldo)
        {
            numero = _numero;
            saldo = _saldo;
        }
        //"numero,saldo"
        public Cuenta(String _cuenta)
        {
            String[] datos = _cuenta.Split(',');
            long.TryParse(datos[0], out numero);
            decimal.TryParse(datos[1], out saldo);
        }

        public long Numero
		{
			get { return numero; }
			set { numero = value; }
		}

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public override string ToString()
        {
            return numero + "," + saldo;
        }

        public void depositar(decimal _monto)
        {
            saldo += _monto;
        }
        public bool girar(decimal _monto)
        {
            if(saldo >= _monto)
            {
                saldo -= _monto;
                return true;
            }
            return false;
        }
    }
}

