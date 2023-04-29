using System;
namespace MA04
{
	public class Vendedor
	{
		private int id;
		private string nombre;
		private double montoAcumulado;/*para ver...*/

		public Vendedor()
		{

		}

		public Vendedor(int _id, string _nombre, double _montoAcumulado)
		{
			id = _id;
			nombre = _nombre;
			montoAcumulado = _montoAcumulado;
		}

		public int getId()
		{
			return id;
		}
		public string getNombre()
		{
			return nombre;
		}
		public double getMontoAcumulado()
		{
			return montoAcumulado;
		}
	}
}

