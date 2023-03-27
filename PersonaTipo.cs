using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBanco
{
    class PersonaTipo
    {
        //encapsulamiento de atributos
        private int id;
        private string nombre;
        private bool activo;

        //Constructor por defecto
        public PersonaTipo()
        {
            id = 0;
            nombre = string.Empty;
            activo = false;
        }
        //constructor por parametros
        public PersonaTipo(int _id, string _nombre)
        {
            id = _id;
            nombre = _nombre;
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
        public bool isActivo()
        {
            return activo;
        }
    }
}
