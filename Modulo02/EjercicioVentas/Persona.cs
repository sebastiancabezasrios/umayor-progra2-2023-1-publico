using System;

namespace EjercicioVentas
{
    public class Persona
    {
        private int id;
        private string rut;
        private string nombre;
        private string apellido;
        private bool activo;

        public Persona()
        {

        }

        public Persona(int _id, string _rut, string _nombre, string _apellido)
        {
            id = _id;
            rut = _rut;
            nombre = _nombre;
            apellido = _apellido;
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
        public string getRut()
        {
            return rut;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getApellido()
        {
            return apellido;
        }
        public bool isActivo()
        {
            return activo;
        }
    }
}