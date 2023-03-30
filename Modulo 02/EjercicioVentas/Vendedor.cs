using System;
using EjercicioVentas;

namespace EjercicioVentas
{
    public class Vendedor : Persona
    {
        private int tiendaId;

        public Vendedor(int _id, string _rut, string _nombre, string _apellido, int _tiendaId) : base(_id, _rut, _nombre, _apellido)
        {
            tiendaId = _tiendaId;
        }

        public int getTiendaId()
        {
            return tiendaId;
        }
    }
}

