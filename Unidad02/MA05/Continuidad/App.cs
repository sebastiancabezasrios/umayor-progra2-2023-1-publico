using System;
namespace Continuidad
{
	public class App
	{
		public static void Main()
		{
			Estudiante est1 = new Estudiante();
			Console.WriteLine("Alumno Nuevo: " + est1.ToString());

			//clase persona (clase base)
			Rut nuevoRut = new Rut(17567890, '1');
			Fecha nacimiento = new Fecha(15,11,1987);
			est1.setRut(nuevoRut);
			est1.setNombreApellido("Pablo", "Vergaray");
			est1.setGenero('M');
			est1.setEstadoCivil('S');
			est1.setNacimiento(nacimiento);
			//clase estudiante... sigue siendo la misma, pero con sus fx propias
			est1.setMatricula(541111);
			est1.setCarrera("Ingenieria");
			est1.setYearIngreso(2022);
            Console.WriteLine("Alumno con Datos: " + est1.ToString());

            //segundo ejemplo
            Rut otroRut = new Rut(12345456, '2');
			Fecha otraFecha = new Fecha(31, 07, 1988);
			Persona p1 = new Persona(otroRut, "Jose", "Sagredo", 'M', 'C', otraFecha);
			Console.WriteLine("persona 1: " + p1.getNombreApellido());

			Estudiante est2 = new Estudiante(p1, 123345, "Informatica", 2021);
			Console.WriteLine("Estudiante 2: " +est2.ToString());
			Console.WriteLine("Estudiante 2: " +est2.getNombreApellido());

			Estudiante est3 = new Estudiante(new Persona(new Rut(11222333, 'K'), "Matias", "Lira", 'M', 'S', new Fecha(17, 6, 2000)), 2233, "Informática", 2023);
            Console.WriteLine("Estudiante 3: " + est3.ToString());
			Console.WriteLine("Est3 Nombre: " + est3.getNombreApellido());

        }
    }
}

