using System;

namespace EjercicioBanco
{
	public class Banco
	{
        private int id;
        private string nombre;
        private bool activo;

        public Banco()
        {
            id = 0;
            nombre = string.Empty;
            activo = false;
        }

        public Banco(int _id, string _nombre)
        {
            id = _id;
            nombre = _nombre;
            activo = true;
        }

        public int getId() { return id; }
        public string getNombre() { return nombre; }
        public bool isActivo() { return activo; }

        public Banco getBancoById(List<Banco> _lista, int _id)
        {
            return _lista.Where(l => l.getId().Equals(_id)).First();
        }

    }
}

