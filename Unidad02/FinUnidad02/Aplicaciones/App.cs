using System;
using FinUnidad02.Clases;
using FinUnidad02.Colecciones;

namespace FinUnidad02.Aplicaciones
{
    // @author: Sebastian Cabezas
    // @rut: 11222333-4
	public class App
	{
        public static void Main (){
            Console.WriteLine("Clase Principal");

            List<Persona> listadoClientes = new List<Persona>();
            /*
            Persona p1 = new Persona("Matias Lira");
            Console.WriteLine(p1.ToString());
            Persona p2 = new Persona("Elias", "Muñoz");
            Persona p3 = new Persona("Felipe", "Salazar");
            listadoClientes.Add(p1);
            listadoClientes.Add(p2);
            listadoClientes.Add(p3);
            */

            // inicio -> Archivo
            string _nombreArchivo = "Prestamo.txt";
            try
            {
                FileStream fs = new FileStream(_nombreArchivo, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(_nombreArchivo);
                string linea;
                string[] campo;
                int index = 1;
                while (!sr.EndOfStream)
                {
                    linea = sr.ReadLine();
                    campo = linea.Split(',');
                    /*
                    if (campo[4] == "Central" || campo[4] == "Oriente")
                    {
                        Console.WriteLine(index + "*" + campo[4]);
                    }
                    else
                    {
                        Console.WriteLine(index + "*ERROR DE LECTURA");
                    }
                    Console.WriteLine(index + "*" + campo[5]);
                    */
                    Persona personaAuxiliar = new Persona(campo[5]);
                    listadoClientes.Add(personaAuxiliar);

                    index++;
                }
                sr.Close();
                fs.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error en el archivo: " + ex);
            }
            // fin -> Archivo

            Biblioteca biblioteca = new Biblioteca("Mayor;Virtual", listadoClientes);
            Console.WriteLine(biblioteca.ToString());

        }
    }
}