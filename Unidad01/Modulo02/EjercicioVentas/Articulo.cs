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

        public Articulo()
        {

        }

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
        public int getTiendaId()
        {
            return tiendaId;
        }
        public bool isActivo()
        {
            return activo;
        }

        public void verArticulos(List<Articulo> _lista, int _tiendaId)
        {
            foreach (Articulo item in _lista)
            {
                if (item.isActivo() && item.getTiendaId() == _tiendaId)
                {
                    Console.WriteLine(item.toString());
                }
            }
        }
        private string toString()
        {
            return "["+id+"]["+nombre+"][Talla:"+ talla + "][Precio:"+precio+"][Stock: "+stock+"]";
        }
        public Articulo getArticuloById(List<Articulo> _lista, int _id)
        {
            return _lista.Where(t => t.getId().Equals(_id)).First();
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

