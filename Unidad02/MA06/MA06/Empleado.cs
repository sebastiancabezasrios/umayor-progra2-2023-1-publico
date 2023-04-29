using System;
using System.Text;

namespace MA06
{
	public class Empleado : Persona
	{
		private double sueldo;

		public Empleado() : base ()
		{
			sueldo = 0;
		}

        public Empleado(Empleado _empleado) : base ()
        {
            sueldo = _empleado.sueldo;
        }

        //se esta ocupando este constructor por parametros, ocupamos cuando hacemos un empleado x
        public Empleado(Persona _p, double _sueldo) : base (_p)
		{
			sueldo = _sueldo;
		}
        //cuando hacemos un admin, ocupamos este constructor
        public Empleado(Persona _p, Empleado _empleado) : base (_p)
        {
			sueldo = _empleado.sueldo;
        }

        public override string ToString()
        {
            //StringBuilder s = new StringBuilder();

            //s.Append(base.ToString());
            //s.Append(",");
            //s.Append(sueldo);

            //return s.ToString();
            return "Empleado " + base.ToString() + " su sueldo es $" + sueldo;
        }

        public override string quienSoy()
        {
            return "Soy un Empleado";
        }
    }
}

