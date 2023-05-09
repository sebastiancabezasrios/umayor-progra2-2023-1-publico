using System;
using System.Text;

namespace MA06
{
	public class Administrativo : Empleado
	{
		private Jornada jornada;
        private EJornada eJornada;
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

        public Administrativo(Empleado _e, EJornada _jornada, double _bono) : base(_e.getPersona(), _e)
        {
            eJornada = _jornada;
            bono = _bono;

            if ((EJornada.Completa.Equals(_jornada)))
            {
                Console.WriteLine("Match");
            }
            else
            {
                Console.WriteLine("NO Match");
            }
        }

        public Administrativo(Persona _p, EJornada _jornada, double _bono) : base(_p)
        {
            eJornada = _jornada;
            bono = _bono;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            s.Append(base.ToString());
            s.Append(",");
			s.Append(eJornada);
			s.Append(",");
			s.Append(bono);

            return s.ToString();
        }

        public override string quienSoy()
        {
            return "Soy un Administrativo";
        }

        public override string guardarBD()
        {
            return "Conectando a la tabla administrativo";
        }
    }
}

