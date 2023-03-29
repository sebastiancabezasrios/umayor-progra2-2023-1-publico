using System;
namespace EjercicioVentasOnline
{
	public class VentaDetalle
	{
		private int id;
		private int ventaId;
		private int articuloId;
		private int precio;
		private int cantidad;

		public VentaDetalle(int _id, int _ventaId, int _articuloId, int _precio, int _cantidad)
		{
			id = _id;
			ventaId = _ventaId;
			articuloId = _articuloId;
			precio = _precio;
			cantidad = _cantidad;
		}
    }
}

