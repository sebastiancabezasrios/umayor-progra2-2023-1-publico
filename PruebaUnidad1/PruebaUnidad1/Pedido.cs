using System;
namespace PruebaUnidad1
{
	public class Pedido
	{
		private string nombreCliente;
		private string tipoRamo;
		private int cantidad;
		private string correo;
		private string prioridad;

		//parte 1
		//propiedades
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string TipoRamo { get => tipoRamo; set => tipoRamo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Prioridad { get => prioridad; set => prioridad = value; }
		//4 constructores
		public Pedido()
		{

		}
		public Pedido(string _nombreCliente, string _tipoRamo, int _cantidad, string _correo, string _prioridad)
		{
            nombreCliente = _nombreCliente;
            tipoRamo = _tipoRamo;
            cantidad = _cantidad;
            correo = _correo;
            prioridad = _prioridad;
        }
		public Pedido(Pedido _pedido)
		{
			nombreCliente = _pedido.NombreCliente;
			tipoRamo = _pedido.TipoRamo;
			cantidad = _pedido.Cantidad;
			correo = _pedido.Correo;
			prioridad = _pedido.Prioridad;
		}
        public override string ToString()
        {
			return "[" + nombreCliente + " | " + tipoRamo + " | " + cantidad + " | " + correo + " | " + prioridad + " ]";
        }
    }
}

