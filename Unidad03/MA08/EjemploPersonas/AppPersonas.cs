using System;
namespace MA08.EjemploPersonas
{
	public class AppPersonas
	{
		public static void Main()
		{
			Console.WriteLine("==>Personas");
			Persona[] listaPersonas = new Persona[4];
            Persona[] listaPersonasPorApellidoPaterno = new Persona[4];


            listaPersonas[0] = new Persona("1-1", "Javi", "Perez", "Gonzalez");
            listaPersonas[1] = new Persona("2-2", "Alejandra", "Tapia", "Niebuhr");
            listaPersonas[2] = new Persona("3-3", "Sebastian", "Arredondo", "Apellido");
            listaPersonas[3] = new Persona("4-4", "Christian", "Carmona", "Mendoza");

            //copiamos a la lista de orden por apellido paterno
            int i=0;
            foreach (Persona p in listaPersonas)
            {
                listaPersonasPorApellidoPaterno[i] = p;
                i++;
            }

            Console.WriteLine("==>Original 1");
			foreach (Persona p in listaPersonas)
			{
				Console.WriteLine(p.ToString());
			}

			Console.WriteLine("==>Ordenada Por Apellido Paterno");
			//llamada al objeto persona, no es necesario pasar parametros
			new Persona().ordenarPorApellidoPaterno(listaPersonasPorApellidoPaterno);
            foreach (Persona p in listaPersonasPorApellidoPaterno)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("==>Original sin cambios?");
            foreach (Persona p in listaPersonas)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("==>Ordenada Por Apellido Materno");
            //llamada al objeto persona, no es necesario pasar parametros
            new Persona().ordenarPorApellidoMaterno(listaPersonas);
            foreach (Persona p in listaPersonas)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("==>Ordenada Por Nombre");
            //llamada al objeto persona, no es necesario pasar parametros
            new Persona().ordenarPorNombre(listaPersonas);
            foreach (Persona p in listaPersonas)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("==>Ordenada Por RUT");
            //llamada al objeto persona, no es necesario pasar parametros
            new Persona().ordenarPorRut(listaPersonas);
            foreach (Persona p in listaPersonas)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}

