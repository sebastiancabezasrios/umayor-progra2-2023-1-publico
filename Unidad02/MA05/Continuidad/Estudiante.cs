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
			matricula = 0;
			carrera = "Sin Carrera";
			yearIngreso = 0;
		}

        public Estudiante(Persona _persona,int _matricula, string _carrera, int _yearIngreso) : base(_persona)
        {
            matricula = _matricula;
            carrera = _carrera;
            yearIngreso = _yearIngreso;
        }

        public void setMatricula(int _matricula)
		{
			matricula = _matricula;
		}
		public void setCarrera(string _carrera)
		{
			carrera = _carrera;
		}
		public void setYearIngreso(int _yearIngreso)
		{
			yearIngreso = _yearIngreso;
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

