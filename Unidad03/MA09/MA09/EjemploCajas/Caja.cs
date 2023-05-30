using System;
namespace MA09.EjemploCajas
{
	public class Caja<T> where T:class
	{
		private T objeto;
		public T Objeto;

		public Caja()
		{
			objeto = null;
			Objeto = null;
		}


		public Caja(T _obj)
		{
			objeto = _obj;
		}
		public Caja(Caja<T> _caja)
		{
			objeto = _caja.objeto;
		}
        public override string ToString()
        {
            return objeto.ToString();
        }

		public void guardar(T _obj)
		{
			objeto = _obj;
		}
		public T sacar() //funcion: retorna el objeto con el tipo de dato T //public tipoDeDato nombreFuncion(), siembre debe retornar
        {
			return objeto;
		}
		public bool estaVacia()
		{
			return objeto == null;
		}

        public void verificarCaja(Caja<T> _caja, string _nombreCaja)
        {
            if (_caja.estaVacia())
            {
                Console.WriteLine("La " + _nombreCaja + " está vacía");
            }
            else
            {
                Console.WriteLine("Contenido de la " + _nombreCaja);
                Console.WriteLine(_caja.ToString());
            }
        }

        public void verificarCaja(string _nombreCaja)
        {
            if (this.estaVacia())
            {
                Console.WriteLine("La " + _nombreCaja + " está vacía");
            }
            else
            {
                Console.WriteLine("Contenido de la " + _nombreCaja);
                Console.WriteLine(this.objeto.ToString());
            }
        }

    }
}

