﻿using System;
namespace Continuidad
{
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
	}
}

