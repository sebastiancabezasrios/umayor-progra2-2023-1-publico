using System;

namespace EjercicioVentas
{
    public class Cliente : Persona
    {
        private string correo;

        public Cliente(int _id, string _rut, string _nombre, string _apellido, string _correo) : base(_id, _rut, _nombre, _apellido)
        {
            correo = _correo;
        }

        public string getCorreo()
        {
            return correo;
        }

        public Cliente getClienteById(List<Cliente> _lista, int _id)
        {
            return _lista.Where(c => c.getId().Equals(_id)).First();
        }
    }
}

