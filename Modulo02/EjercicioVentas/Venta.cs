using System;
namespace EjercicioVentasOnline
{
	public class Venta
	{
		private int id;
		private string fecha;
		private int tiendaId;
		private int vendedorId;
		private int clienteId;
		private int medioPagoId;
		private bool activo;

		public Venta(int _id, string _fecha, int _tiendaId, int _vendedorId, int _clienteId, int _medioPagoId)
		{
			id = _id;
			fecha = _fecha;
			tiendaId = _tiendaId;
			vendedorId = _vendedorId;
			clienteId = _clienteId;
			medioPagoId = _medioPagoId;
			activo = true;
		}
	}

	
}

