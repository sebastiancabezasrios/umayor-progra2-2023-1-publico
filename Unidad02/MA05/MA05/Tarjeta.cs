using System;
using System.Security.Cryptography;

namespace MA05
{
	public class Tarjeta
	{
		private int id;
		private double numero;
		private string nombreBanco;

		public Tarjeta()
		{
            id = 0;
            numero = 0;
            nombreBanco = "Sin Nombre";
        }

        public Tarjeta(int _id, double _numero, string _nombreBanco)
        {
			id = _id;
			numero = _numero;
			nombreBanco = _nombreBanco;
        }

        public int getId()
		{
			return id;
		}

		public double getNumero()
		{
			return numero;
		}

		public string getNombreBanco()
		{
			return nombreBanco;
		}
	}
}

