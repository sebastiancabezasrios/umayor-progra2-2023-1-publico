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
    }
}

