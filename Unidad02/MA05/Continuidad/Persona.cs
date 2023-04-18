using System;
namespace Continuidad
{
	public class Persona
	{
		protected Rut rut;
		private string nombre;
        private string apellido;
        private char genero;
        private char estadoCivil;
		private Fecha fechaNac;

		public Persona()
		{
			fechaNac = new Fecha();
		}

        public override string ToString()
        {
			return "Persona de rut: " + rut.ToString() + " su nombre es " + nombre + " " + apellido + ", de genero [" + genero + "] está [" + estadoCivil + "] y nacio en la fecha [" + fechaNac.ToString() + "]";
        }
    }
}

