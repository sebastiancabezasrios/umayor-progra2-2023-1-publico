using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBanco
{
    class CuentaTipo
    {
        //encapsulamiento de atributos
        private int id;
        private string nombre;
        private string descripcion;
        private bool activo;

        //Constructor por defecto
        public CuentaTipo() {
            id = 0;
            nombre = string.Empty;
            descripcion = string.Empty;
            activo = false;
        }
        //constructor por parametros
        public CuentaTipo(int _id, string _nombre, string _descripcion)
        {
            id = _id;
            nombre = _nombre;
            descripcion = _descripcion;
            activo = true;
        }

        //mutadores -> son los llamados para almacenar el valor de un atributo
        public void setId(int _id)
        {
            id = _id;
        }
        public void setNombre(string _nombre)
        {
            nombre = _nombre;
        }
        public void setDescripcion(string _descripcion)
        {
            descripcion = _descripcion;
        }
        public void setActivo(bool _activo)
        {
            activo = _activo;
        }
        //accesadores -> son los llamados para devolver el valor de un atributo
        public int getId()
        {
            return id;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getDescripcion()
        {
            return descripcion;
        }
        public bool isActivo()
        {
            return activo;
        }
    }
}
