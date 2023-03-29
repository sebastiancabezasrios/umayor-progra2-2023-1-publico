using System;
namespace EjercicioVentasOnline
{
	public class Tienda
	{
		private int id;
		private string nombre;
		private bool activo;

		public Tienda()
		{

		}

		public Tienda(int _id, string _nombre)
		{
			id = _id;
			nombre = _nombre;
			activo = true;
		}

		public int getId()
		{
			return id;
		}
		public string getNombre()
		{
			return nombre;
		}
	}
}

