using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBanco
{
    internal class App
    {
        public static void Main(String[]args)
        {
            Console.WriteLine("Tarea Banco");
            //crear un objeto abstracto del tipo Cuenta Tipo

            //instancia del objeto
            //[Tipo de Dato Abstracto] [nombre de la instancia] = new [Constructor(): constructor por defecto]
            CuentaTipo cuentaTipo1 = new CuentaTipo();
            cuentaTipo1.setId(100);
            cuentaTipo1.setNombre("Vista");
            cuentaTipo1.setActivo(true);
            //instanciar otro objeto del tipo CuentaTipo
            CuentaTipo cuentaTipo2 = new CuentaTipo();
            CuentaTipo cuentaTipo3 = new CuentaTipo(102, "Credito", "Propia del Banco");

            //crear un objeto abstracto del tipo de Persona
            //PersonaTipo personaTipo1 = new PersonaTipo(1, "Natural");
            //PersonaTipo personaTipo2 = new PersonaTipo(2, "Empresa");
            PersonaTipo[] personaTipoLista = new PersonaTipo[2];
            personaTipoLista[0] = new PersonaTipo(1, "Natural");
            personaTipoLista[1] = new PersonaTipo(2, "Empresa");

            //Arreglos -> Array -> "Listas tienen otras propiedades: add, remove, item... permite que sea dinamico"
            int[] arreglo = new int[2];
            arreglo[0] = 10;
            arreglo[1] = 20;
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(i + ": " + arreglo[i]);
            }

            for (int i = 0; i < personaTipoLista.Length; i++)
            {
                Console.WriteLine(personaTipoLista[i].getId() + ": " + personaTipoLista[i].getNombre());
            }

            /*
            if (cuentaTipo1.isActivo())
            {
                Console.WriteLine("Tipo 1 Cuenta ["+cuentaTipo1.getNombre()+"] tiene el ID: " + cuentaTipo1.getId());
            }
            else
            {
                Console.WriteLine("Cuenta tipo 1 Inactiva");
            }

            if (cuentaTipo2.isActivo())
            {
                Console.WriteLine("Tipo 2 Cuenta [" + cuentaTipo2.getNombre() + "] tiene el ID: " + cuentaTipo2.getId());
            }
            else
            {
                Console.WriteLine("Cuenta tipo 2 Inactiva");
            }

            if (cuentaTipo3.isActivo())
            {
                Console.WriteLine("Tipo 3 Cuenta [" + cuentaTipo3.getNombre() + "] tiene el ID: " + cuentaTipo3.getId());
            }
            else
            {
                Console.WriteLine("Cuenta tipo 3 Inactiva");
            }
            */
        }
    }
}
