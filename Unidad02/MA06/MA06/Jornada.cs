using System;
namespace MA06
{
	public class Jornada
	{
		private bool completa;
		private bool mediaJornada;

		public Jornada()
		{
			completa = false;
			mediaJornada = false;
		}

		public Jornada(bool _completa)
		{
			if (_completa)
			{
				completa = _completa;
				mediaJornada = false;
			}
			else
			{
				completa = false;
				mediaJornada = true;
			}
		}

		public bool getJornadaCompleta()
		{
			return completa;
		}

		public bool getMediaJornada()
		{
			return mediaJornada;
		}
	}
}

