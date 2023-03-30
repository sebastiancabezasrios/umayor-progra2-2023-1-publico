using System;
namespace EjercicioVentas
{
    public class Tienda
    {
        private int id;
        private string nombre;
        private bool activo;

        public Tienda()
        {
            id = 0;
            nombre = string.Empty;
            activo = false;
        }

        public Tienda(int _id, string _nombre)
        {
            id = _id;
            nombre = _nombre;
            activo = true;
        }
        public void setActivo(bool _activo)
        {
            activo = _activo;
        }
        public int getId()
        {
            return id;
        }
        public string getNombre()
        {
            return nombre;
        }
        public bool isActivo()
        {
            return activo;
        }

        public IEnumerable<Articulo> getArticulosTiendaId(List<Articulo> _lista, int _tiendaId)
        {
            return _lista.Where(t => t.getTiendaId().Equals(_tiendaId));
        }
        public IEnumerable<Vendedor> getVendedoresTiendaId(List<Vendedor> _lista, int _tiendaId)
        {
            return _lista.Where(t => t.getTiendaId().Equals(_tiendaId));
        }
        public IEnumerable<Cliente> getClientesTiendaId(List<Cliente> _listaCliente, List<Venta> _listaVentas,int _tiendaId)
        {
            IEnumerable<Venta> filtroVentas = _listaVentas.Where(venta => venta.getTiendaId().Equals(_tiendaId));

            return null;
            //return _listaCliente.Where(cliente => {
            //    cliente.getId().Equals(1).s
            //});
        }
    }
}

