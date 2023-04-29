using System;
using System.Text;

namespace MA06
{
	public class Administrativo : Empleado
	{
		private Jornada jornada;
		private double bono;

		public Administrativo() : base()
		{
			jornada = new Jornada();
			bono = 0;
		}
        //se esta ocupando este constructor por parametros
        public Administrativo(Empleado _e, Jornada _jornada, double _bono) : base(_e.getPersona(), _e)
		{
			jornada = _jornada;
			bono = _bono;
		}

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            s.Append(base.ToString());
            s.Append(",");
			s.Append(jornada.getJornadaCompleta());
			s.Append(",");
			s.Append(bono);

            return s.ToString();
        }

        public override string quienSoy()
        {
            return "Soy un Administrativo";
        }
    }
}

