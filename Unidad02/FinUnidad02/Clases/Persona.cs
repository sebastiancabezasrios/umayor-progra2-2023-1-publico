using System;
namespace FinUnidad02.Clases
{
	public class Persona
	{
		//atributos de la clase
        private string nombre;
        private string apellido;

		//constructor 1: por defecto
        public Persona()
		{
			nombre = "Sin Nombre";
			apellido = "Sin Apellido";
        }
		//contructor 2: con parametros
		public Persona(string _nombre, string _apellido)
		{
			nombre = _nombre;
			apellido = _apellido;
		}
		//constructor 3: unico string separado por simbolos; por ejemplo: ";"
		public Persona(string _entrada)
		{
			string [] arr = _entrada.Split(" ");

            nombre = arr[0]; //antes del ;
            apellido = arr[1]; //despues del primer ;
        }
		//constructor 4: de copia
		public Persona(Persona _persona)
		{
			nombre = _persona.nombre;
			apellido = _persona.apellido;
		}

        public override string ToString()
        {
			return nombre + " " + apellido;
        }

		public string getNombre()
		{
			return nombre;
		}
    }
}

