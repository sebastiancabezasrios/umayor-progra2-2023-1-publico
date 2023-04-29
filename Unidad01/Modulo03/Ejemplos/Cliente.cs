using System;
namespace Ejemplos
{
	public class Cliente
	{
		private String nombre;
		//private string nombre;
		public List<Cuenta> listaCuentas;

		public Cliente()
		{
			nombre = "Sin_Definir";
			listaCuentas = new List<Cuenta>();
		}
		public Cliente(String _nombre)
		{
			nombre = _nombre;
			listaCuentas = new List<Cuenta>();
		}
        public Cliente(Cliente _cliente)
        {
            nombre = _cliente.nombre;
            listaCuentas = _cliente.listaCuentas;
        }

        public String Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		override public String ToString()
		{
			return nombre;
		}
	}
}

