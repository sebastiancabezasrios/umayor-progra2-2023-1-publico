using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            CuentaTipo cuentaTipo3 = new CuentaTipo(102, "Corriente", "Propia del Banco");

            //crear un objeto abstracto del tipo de Persona
            //PersonaTipo personaTipo1 = new PersonaTipo(1, "Natural");
            //PersonaTipo personaTipo2 = new PersonaTipo(2, "Empresa");
            PersonaTipo[] personaTipoLista = new PersonaTipo[2];
            personaTipoLista[0] = new PersonaTipo(1, "Natural");
            personaTipoLista[1] = new PersonaTipo(2, "Empresa");

            //Banco
            Banco banca = new Banco(1, "Banco Mayor");
            Banco banquito = new Banco(2, "Banco Banquito");

            //Cliente
            Cliente[] clienteArray = new Cliente[3];
            clienteArray[0] = new Cliente(10, "1-1", "Seba", personaTipoLista[0].getId());
            string tipoPersona = "natural";
            int tipoPersonaId = -1;
            for (int i = 0; i < personaTipoLista.Length; i++)
            {
                if (tipoPersona.ToLower().Equals(personaTipoLista[i].getNombre().ToLower()))
                {
                    tipoPersonaId = personaTipoLista[i].getId();
                    break;
                }
            }
            clienteArray[1] = new Cliente(20, "2-2", "Elias", tipoPersonaId);
            clienteArray[2] = new Cliente(30, "3-3", "Pablo", 2);

            for(int i=0; i<clienteArray.Length; i++)
            {
                Console.WriteLine("Cliente: " + clienteArray[i].getNombre() + "\nRut: " + clienteArray[i].getRut()+"\nTipo Persona: " + new PersonaTipo().getPersonaTipoById(personaTipoLista, clienteArray[i].getClienteTipoId()).getNombre()+ "\n");
            }

            Cuenta[] cuentasArray = new Cuenta[5];

            cuentasArray[0] = new Cuenta(1,"123-1234-1", 20, 1, 100,10000);
            cuentasArray[1] = new Cuenta(2,"123-2", 20, 1, 102,1000);
            cuentasArray[2] = new Cuenta(3, "123-1234-2", 10, 1, 100, 15000);
            cuentasArray[3] = new Cuenta(4, "123-1234-3", 30, 1, 102, 5000);
            cuentasArray[4] = new Cuenta(5, "123-1234-3", 30, 2, 102, 5000);

            //saldos de un cliente en específico (Tengo 3 clientes en un array)
            int montoTotal = 0;
            for(int i=0; i < clienteArray.Length; i++)
            {
                montoTotal += clienteArray[i].getSaldoTotal(cuentasArray, clienteArray[i].getId(), banquito.getId());
                Console.WriteLine("Saldos del cliente:["+ clienteArray[i].getNombre()+ "] " + clienteArray[i].getSaldoTotal(cuentasArray, clienteArray[i].getId(), banquito.getId()));
            }
            Console.WriteLine("Monto total que administra el banco ["+ banquito.getNombre()+ "] es: $" + montoTotal);







            //Arreglos -> Array -> "Listas tienen otras propiedades: add, remove, item... permite que sea dinamico"
            /*
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
            }*/

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
