using System;
namespace Continuidad
{
	public class Rut
	{
		private int numero;
		private char dv;

		public Rut()
		{
		}

		public Rut(int _numero, char _dv)
		{
			numero = _numero;
			dv = _dv;
		}

        public override string ToString()
        {
            return numero + "-" + dv;
        }
    }
}

