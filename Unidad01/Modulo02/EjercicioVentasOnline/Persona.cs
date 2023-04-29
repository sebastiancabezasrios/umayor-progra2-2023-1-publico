using System;
namespace EjercicioVentasOnline
{
	public class Persona
	{
		private int id;
		private string rut;
		private string nombre;
		private string apellido;
		private bool activo;

        public Persona(int _id, string _rut, string _nombre, string _apellido)
        {
			id = _id;
			rut = _rut;
			nombre = _nombre;
			apellido = _apellido;
			activo = true;
        }

		public int getId()
		{
			return id;
		}
		public string getRut()
		{
			return rut;
		}
		public string getNombre()
		{
			return nombre;
		}
		public string getApellido()
		{
			return apellido;
		}
    }
}