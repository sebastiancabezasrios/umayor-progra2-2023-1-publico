using System;

namespace EjercicioVentas
{
    public class Vendedor : Persona
    {
        private int tiendaId;

        public Vendedor() : base ()
        {

        }

        public Vendedor(int _id, string _rut, string _nombre, string _apellido, int _tiendaId) : base(_id, _rut, _nombre, _apellido)
        {
            tiendaId = _tiendaId;
        }

        public int getTiendaId()
        {
            return tiendaId;
        }

        public Vendedor getVendedorById(List<Vendedor> _lista, int _id)
        {
            return _lista.Where(v => v.getId().Equals(_id)).First();
        }
        public void verVendedores(List<Vendedor> _lista, int _tiendaId)
        {
            foreach (Vendedor item in _lista)
            {
                if (item.isActivo() && item.getTiendaId() == _tiendaId)
                {
                    Console.WriteLine(item.toString());
                }
            }
        }
        private string toString()
        {
            return "["+ getId() +"]["+getNombre()+" "+getApellido()+"]";
        }
    }
}

