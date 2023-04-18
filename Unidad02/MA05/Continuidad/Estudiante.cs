using System;
using System.Text;

namespace Continuidad
{
	public class Estudiante:Persona
	{
		private int matricula;
		private string carrera;
		private int yearIngreso;

		public Estudiante():base()
		{
		}

		public int getMatricula()
		{
			return matricula;
		}

		public string getCarrera()
		{
			return carrera;
		}

		public int getYearIngreso()
		{
			return yearIngreso;
		}

        public override string ToString()
        {
			StringBuilder s = new StringBuilder();

			s.Append(base.ToString());
			s.Append(",");
			s.Append(matricula);
            s.Append(",");
            s.Append(carrera);
            s.Append(",");
            s.Append(yearIngreso);

            return s.ToString();
        }
    }
}

