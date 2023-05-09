using System;
namespace MA06
{
    //Comentario :)
    public class Persona
    {
        protected Rut rut;
        private string nombre;
        private string apellido;
        private char genero;
        private char estadoCivil;
        private Fecha fechaNac;

        public Persona()
        {
            rut = new Rut();
            nombre = "Sin Nombre";
            apellido = "Sin Apellido";
            genero = 'X';
            estadoCivil = 'X';
            fechaNac = new Fecha();
        }

        public Persona(Rut _rut, string _nombre, string _apellido, char _genero, char _estadoCivil, Fecha _nacimiento)
        {
            rut = _rut;
            nombre = _nombre;
            apellido = _apellido;
            genero = _genero;
            estadoCivil = _estadoCivil;
            fechaNac = _nacimiento;
        }
        //constructor de copia
        //se esta ocupando este constructor
        public Persona(Persona _p)
        {
            rut = _p.rut;
            nombre = _p.nombre;
            apellido = _p.apellido;
            genero = _p.genero;
            estadoCivil = _p.estadoCivil;
            fechaNac = _p.fechaNac;
        }

        public override string ToString()
        {
            return "Persona de rut: " + rut.ToString() + " su nombre es " + nombre + " " + apellido + ", de genero [" + genero + "] está [" + estadoCivil + "] y nacio en la fecha [" + fechaNac.ToString() + "]";
        }

        public void setRut(Rut _rut)
        {
            rut = _rut;
        }

        public void setNombreApellido(string _nombre, string _apellido)
        {
            nombre = _nombre;
            apellido = _apellido;
        }

        public void setGenero(char _genero)
        {
            genero = _genero;
        }

        public void setEstadoCivil(char _estadoCivil)
        {
            estadoCivil = _estadoCivil;
        }

        public void setNacimiento(Fecha _nacimiento)
        {
            fechaNac = _nacimiento;
        }

        public string getNombreApellido()
        {
            return nombre + " " + apellido;
        }

        public Persona getPersona()
        {
            return this;
        }

        public virtual string quienSoy()
        {
            return "Soy una Persona";
        }

        public virtual string guardarBD()
        {
            return "Conectando a la tabla persona";
        }

        public string getRut()
        {
            return rut.ToString();
        }

        public char getGenero()
        {
            return genero;
        }

        public char getEstadoCivil()
        {
            return estadoCivil;
        }
    }
}

