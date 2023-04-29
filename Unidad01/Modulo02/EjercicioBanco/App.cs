using System;

namespace EjercicioBanco
{
	public class App
	{
		public static void Main(String[] args)
		{
			Console.WriteLine("Ejercicio Banco");
			//1 hacer todas las clases de objetos enlistables y llenar con valores
			CuentaTipo[] cuentaTipoArreglo = new CuentaTipo[3];
			cuentaTipoArreglo[0] = new CuentaTipo(100, "Vista", "desc vista");
			cuentaTipoArreglo[1] = new CuentaTipo(101, "Ahorro", "desc ahorro");
			cuentaTipoArreglo[2] = new CuentaTipo(102, "Corriente", "desc cte");

			ClienteTipo[] clienteTipoArreglo = new ClienteTipo[2];
			clienteTipoArreglo[0] = new ClienteTipo(1, "Persona Natural");
			clienteTipoArreglo[1] = new ClienteTipo(2, "Empresa");

			//2 hacer las clases de objetos que no dependen de otras clases
			List<Banco> bancoLista = new List<Banco>();
            bancoLista.Add(new Banco(1, "Banco Mayor"));
            bancoLista.Add(new Banco(2, "Banco Banquito"));
            
			//3 hacer las clases que dependen de 1 objeto
			List<Cliente> listaCliente = new List<Cliente>();
            //Al utilizar List, puedo recorrer con foreach y acceder a los objetos
            //ventaja: es dinámica, tiene metodos propios
            listaCliente.Add(new Cliente(1, "1-1", "Seba ", 1));
            listaCliente.Add(new Cliente(2, "2-2", "Elias", 1));
            listaCliente.Add(new Cliente(3, "3-3", "Pablo", 2));
			
			//4 hacer las clases que dependen de 2 o mas objetos
			List<Cuenta> listaCuentas = new List<Cuenta>();
            listaCuentas.Add(new Cuenta(1, "v11-111", 1, 1, 1, 10000));
            listaCuentas.Add(new Cuenta(2, "a22-111", 1, 1, 2, 5000));
            listaCuentas.Add(new Cuenta(3, "c33-111", 1, 2, 3, 5000));
            listaCuentas.Add(new Cuenta(4, "v22-112", 2, 1, 1, 10000));
            listaCuentas.Add(new Cuenta(5, "a22-112", 3, 1, 2, 10000));

            //Preguntas de la guia:
            //saldos de un cliente
            //	-> pidamos al usuario que elija el cliente
            Console.WriteLine("Lista Clientes\n+-+-----+");
            foreach (Cliente cliente in listaCliente)
			{
                Console.WriteLine("|"+cliente.getId()+"|"+cliente.getNombre()+"|");
                //Console.WriteLine(cliente.getNombre());
			}
			Console.Write("+-+-----+\nIngrese el ID del cliente que desea saber el saldo: ");
			int idCliente = int.Parse(Console.ReadLine());
			int idBanco = 1;
			Console.WriteLine(new Cliente().getClienteById(listaCliente, idCliente).getNombre().Trim() + " en el " + new Banco().getBancoById(bancoLista, idBanco).getNombre() + " tiene un saldo total de: $" + new Cliente().getSaldoTotal(listaCuentas, idCliente, idBanco));
		}
    }
}

