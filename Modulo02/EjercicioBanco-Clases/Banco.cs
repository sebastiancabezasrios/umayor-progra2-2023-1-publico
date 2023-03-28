using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBanco
{
    class Banco
    {
        private int id;
        private string nombre;
        private bool activo;

        public Banco(int _id, string _nombre)
        {
            id = _id;
            nombre = _nombre;
            activo = true;
        }

        public int getId() { return id; }
        public string getNombre() { return nombre; }
        public bool isActivo() { return activo; }
    }
    
}
