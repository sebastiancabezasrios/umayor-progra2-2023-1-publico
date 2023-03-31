using System;

namespace EjercicioVentas
{
    public class Articulo
    {
        private int id;
        private string codigo;
        private string nombre;
        private string talla;
        private int precio;
        private int stock;
        private int tiendaId;
        private bool activo;

        public Articulo(int _id, string _codigo, string _nombre, string _talla, int _precio, int _stock, int _tiendaId)
        {
            id = _id;
            codigo = _codigo;
            nombre = _nombre;
            talla = _talla;
            precio = _precio;
            stock = _stock;
            tiendaId =_tiendaId;
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
        public string getCodigo()
        {
            return codigo;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getTalla()
        {
            return talla;
        }
        public int getPrecio()
        {
            return precio;
        }
        public int getStock()
        {
            return stock;
        }
        public int getTienda()
        {
            return tiendaId;
        }
        public bool isActivo()
        {
            return activo;
        }

        public bool descontarStock(int _cantidad)
        {
            if (stock <= _cantidad)
            {
                stock -= _cantidad;
                return true;
            }
            return false;
        }
    }
}

