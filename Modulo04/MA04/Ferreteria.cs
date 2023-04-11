using System;
using System.Security.Cryptography;

namespace MA04
{
	public class Ferreteria
	{
		private int id;
		private string nombre;
		private string rut;
		private List<Vendedor> listaVendedores;

		//constructor por defecto
        public Ferreteria()
        {
			listaVendedores = new List<Vendedor>();
		}

		//metodo o funcion para agregar elementos a la lista
		public void agregarVendedor(Vendedor _vendedor)
		{
			listaVendedores.Add(_vendedor);
		}

		//respuesta:A forma de funcion con retorno de lista
		public List<Vendedor> getNominaVendedores()
		{
			return listaVendedores;
		}
		//respuesta:A forma de metodo con impresion de la lista
		public void nominaVendedores()
		{
			foreach (Vendedor item in listaVendedores)
			{
				Console.WriteLine(item.getId() + "] " + item.getNombre());
			}
		}
		//respuesta: B
		public string getNombreMontoVendedorConMayorVenta()
		{
			double montoMaximo = 0;
			string nombre = "";
            foreach (Vendedor item in listaVendedores)
            {
                if (item.getMontoAcumulado() > montoMaximo)
				{
					montoMaximo = item.getMontoAcumulado();
					nombre = item.getNombre();
				}
            }
			//de esta manera, le damos la posibilidad al programador
			//de hacer un split al slash y obtener los 2 valores por separado.
            return nombre+"/"+montoMaximo;
		}
		//respuesta: C
		public double getMontoTotalVendido()
		{
			double total = 0;
            foreach (Vendedor item in listaVendedores)
            {
				total += item.getMontoAcumulado();
            }
			return total;
        }
        //respuesta: D
        //d. Nómina vendedores con ventas inferiores a un monto determinado
		//intentar con WHERE
		//public List<Vendedor> getNominaVendedoresVentasInferioresA(double _montoDeterminado)
		public IEnumerable<Vendedor> getNominaVendedoresVentasInferioresA(double _montoDeterminado)
		{
			/*
			List<Vendedor> listaRespuesta = new List<Vendedor>();
            foreach (Vendedor item in listaVendedores)
            {
                if (item.getMontoAcumulado() < _montoDeterminado)
				{
					listaRespuesta.Add(item);
                }
            }
            return listaRespuesta;
			*/
			return listaVendedores.Where(vendedor => vendedor.getMontoAcumulado() < _montoDeterminado);

        }
        //respuesta: E
        //Porcentaje vendido por un determinado vendedor. Respecto de la venta total
		public double getPorcentajeVendidoRespectoVentaTotal(Vendedor _vendedor)
		{
            return _vendedor.getMontoAcumulado()/getMontoTotalVendido()*100;
        }
        public double getPorcentajeVendidoRespectoVentaTotal(int _id)
        {
			return listaVendedores.Where(v => v.getId() == _id).First().getMontoAcumulado() / getMontoTotalVendido() * 100;
        }
        //respuesta: F
        //Monto de comisión de un determinado vendedor. El porcentaje se entrega
        //como parámetro
		public double getMontoComisionVendedorByParametro(int _idVendedor, double _porcentaje)
		{
			return listaVendedores.Where(v => v.getId() == _idVendedor).First().getMontoAcumulado() * (_porcentaje/100);
        }
        //respuesta: G
        //Monto vendido por un determinado vendedor. Nombre se pasa como
        //parámetro
		//siempre que comparemos strings debemos hacer lo siguiente: pasar a minusculas o mayusculas, pero lo mismo para ambos.
		public double getMontoVendidoByNombre(string _nombre)
		{
			return listaVendedores.Where(ven => ven.getNombre().ToLower().Equals(_nombre.ToLower())).First().getMontoAcumulado();
		}
    }



    //opcion1: retornar una lista (tomaria yo y manuel)
    //opcion2: un metodo que muestre la lista 
}