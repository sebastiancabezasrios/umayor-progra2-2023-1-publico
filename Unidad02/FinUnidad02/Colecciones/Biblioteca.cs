using System;
using System.Reflection;
using System.Text;
using FinUnidad02.Clases;//esta dentro de este namespace o package

namespace FinUnidad02.Colecciones
{
	public class Biblioteca
	{

		private string nombre;
		private string sede;
		private List<Persona> listaPersonas;

		public Biblioteca()
		{
			nombre = "Sin Nombre";
			sede = "Sin Sede";
			listaPersonas = new List<Persona>();
		}

		public Biblioteca (string _entrada, List<Persona> _listaPersonas)
		{
			string[] arr = _entrada.Split(";");
			nombre = arr[0];
			sede = arr[1];
            listaPersonas = _listaPersonas;
        }

        public override string ToString()
        {
            //return "Biblioteca " + nombre + " [Sede: " + sede + "]";
            StringBuilder s = new StringBuilder();
			s.Append("Biblioteca " + nombre + " [Sede: " + sede + "]\n");
			s.Append("Listado de Clientes:\n");

			int index = 1;
			//for each tipo JavaScript
			/*
			listaPersonas.ForEach(p => {
				s.Append(index+"*"+p.ToString()+"\n");
				index++;
			});
			*/
			//for each tradicional
			foreach (Persona item in listaPersonas)
			{
                s.Append(index + "*" + item.ToString() + "\n");
                index++;
            }

			return s.ToString();
        }

    }
}

