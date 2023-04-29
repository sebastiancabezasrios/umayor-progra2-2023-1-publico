using System;
namespace EjercicioBanco
{
	public class ClienteTipo
	{
        //encapsulamiento de atributos
        private int id;
        private string nombre;
        private bool activo;

        //Constructor por defecto
        public ClienteTipo()
        {
            id = 0;
            nombre = string.Empty;
            activo = false;
        }
        //constructor por parametros
        public ClienteTipo(int _id, string _nombre)
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

        public int getIdByNombre(string _nombre)
        {
            //TODO
            return 0;
        }

        public ClienteTipo getPersonaTipoById(ClienteTipo[] arreglo, int _id)
        {
            //Console.WriteLine("Debug: En getPersonaById");
            for (int i = 0; i < arreglo.Length; i++)
            {
                //Console.WriteLine("Debug: For arreglo");

                if (arreglo[i].getId() == _id)
                {
                    //Console.WriteLine("Debug: ID Encontrado");
                    return arreglo[i];
                }
            }
            //Console.WriteLine("Debug: No Encontrado");
            return null;
        }
    }
}