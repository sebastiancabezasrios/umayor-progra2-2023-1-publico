using System;
using System.Text;

namespace MA06
{
	public class Docente : Empleado
	{
		private int horasDeClase;
		private string gradoAcademico;

		public Docente() : base()
		{
			horasDeClase = 0;
			gradoAcademico = "Sin Grado Académico";
		}

		public Docente(Empleado _e, int _hc, string _ga) : base (_e.getPersona(), _e)
		{
			horasDeClase = _hc;
			gradoAcademico = _ga;
		}

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

			s.Append(base.ToString());
			s.Append(";");
			s.Append(horasDeClase + " Horas");
            s.Append(";");
            s.Append("Grado Académico: " + gradoAcademico);

			return s.ToString();
        }

        public string quienSoy()
        {
            return "Soy un Docente";
        }
    }
}

