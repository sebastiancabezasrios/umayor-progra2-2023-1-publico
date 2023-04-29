using System;
namespace PruebaUnidad1
{
	public class Kiosko
	{
		private int id;
		private int stockRamo1;
		private int stockRamo2;
		private int stockRamo3;
		List<Pedido> listaPedidos;
		List<Pedido> listaPedidosFactibles;
        List<Pedido> listaPedidosSinStock;

        public Kiosko()
		{
			listaPedidos = new List<Pedido>();
            listaPedidosFactibles = new List<Pedido>();
            listaPedidosSinStock = new List<Pedido>();
			stockRamo1 = 10;
			stockRamo2 = 15;
			stockRamo3 = 5;
        }
		public Kiosko(int _stockRamo1, int _stockRamo2, int _stockRamo3)
		{
			listaPedidos = new List<Pedido>();
            listaPedidosFactibles = new List<Pedido>();
            listaPedidosSinStock = new List<Pedido>();
            stockRamo1 = _stockRamo1;
			stockRamo2 = _stockRamo2;
			stockRamo3 = _stockRamo3;
		}
        public override string ToString()
        {
			return "Kiosko [Stock Ramo 1: " + stockRamo1 + " | Stock Ramo 2: " + stockRamo2 + " | Stock Ramo 3: " + stockRamo3 + " | Pedidos: " + listaPedidos.Count() + " | Pedidos Factibles: " + listaPedidosFactibles.Count() + " | Pedidos Sin Stock: " + listaPedidosSinStock.Count() + "]";
        }
		public void asignarStocks(int _stock1, int _stock2, int _stock3)
		{
            stockRamo1 = _stock1;
            stockRamo2 = _stock2;
            stockRamo3 = _stock3;
        }
		public string mostrarPedidosFactiles(string _prioridad)
		{
			string salida = "\t\tPEDIDOS FACTIBLES DE PRIORIDAD " + _prioridad + "\n";
			foreach (Pedido pedido in listaPedidosFactibles)
			{
				if (pedido.Prioridad.ToUpper().Equals(_prioridad))
				{
					salida += pedido.ToString() + "\n";
				}
			}
			return salida;
		}
		public string mostrarSinStock()
		{
			string salida = "\t\tPEDIDOS SIN STOCK\n";
			foreach (Pedido pedido in listaPedidosSinStock)
			{
				salida += pedido.ToString() + "\n";
			}
			return salida;
		}
		public IEnumerable<Pedido> mostrarPrioritarios()
		{
			return listaPedidosFactibles.Where(pf => pf.Prioridad.Equals("ALTA"));
		}
		//parte 3
		public Kiosko(int _stockRamo1, int _stockRamo2, int _stockRamo3, string _nombreArchivo)
		{
			listaPedidos = new List<Pedido>();
            listaPedidosFactibles = new List<Pedido>();
            listaPedidosSinStock = new List<Pedido>();
            stockRamo1 = _stockRamo1;
            stockRamo2 = _stockRamo2;
            stockRamo3 = _stockRamo3;
			//lista pedidos se llena con lo que esta en el archivo
			//por cada pedido leido del archivo, se debe verificar el stock segun las unidades pedidas del tipo de ramo
			// inicio -> Archivo
			try
			{
				FileStream fs = new FileStream(_nombreArchivo, FileMode.Open, FileAccess.Read);
				StreamReader sr = new StreamReader(_nombreArchivo);
				string linea;
				string[] campo;
				while (!sr.EndOfStream)
				{
					linea = sr.ReadLine();
					campo = linea.Split(',');
                    //public Pedido(string _nombreCliente, string _tipoRamo, int _cantidad, string _correo, int _prioridad)
                    listaPedidos.Add(new Pedido(campo[0], campo[1], int.Parse(campo[2]), campo[3], campo[4]));
				}
				sr.Close();
				fs.Close();
			}
			catch (IOException ex)
			{
				Console.WriteLine("Error en el archivo: " + ex);
			}
			// fin -> Archivo
			foreach (Pedido pedido in listaPedidos)
			{
				//si hay stock para atender el pedido, se agrega a la lista de pedidos factibles y se descuenta la cantidad al stock del ramo correspondiente.
				if (pedido.TipoRamo.Equals("Ramo1") && pedido.Cantidad <= stockRamo1)
				{
					//Console.WriteLine("+ Pedido: " + pedido.TipoRamo + " Cantidad " + pedido.Cantidad);
					listaPedidosFactibles.Add(pedido);
					stockRamo1 -= pedido.Cantidad;
				}else if (pedido.TipoRamo.Equals("Ramo1") && pedido.Cantidad > stockRamo1)
				{
					//Console.WriteLine("- Pedido: " + pedido.TipoRamo + " Cantidad " + pedido.Cantidad);
					listaPedidosSinStock.Add(pedido);
                }

                if (pedido.TipoRamo.Equals("Ramo2") && pedido.Cantidad <= stockRamo2)
                {
                    //Console.WriteLine("+ Pedido: " + pedido.TipoRamo + " Cantidad " + pedido.Cantidad);
                    listaPedidosFactibles.Add(pedido);
                    stockRamo2 -= pedido.Cantidad;
                }
                else if (pedido.TipoRamo.Equals("Ramo2") && pedido.Cantidad > stockRamo2)
                {
                    //Console.WriteLine("- Pedido: " + pedido.TipoRamo + " Cantidad " + pedido.Cantidad);
                    listaPedidosSinStock.Add(pedido);
                }

                if (pedido.TipoRamo.Equals("Ramo3") && pedido.Cantidad <= stockRamo3)
                {
                    //Console.WriteLine("+ Pedido: " + pedido.TipoRamo + " Cantidad " + pedido.Cantidad);
                    listaPedidosFactibles.Add(pedido);
                    stockRamo3 -= pedido.Cantidad;
                }
                else if (pedido.TipoRamo.Equals("Ramo3") && pedido.Cantidad > stockRamo3)
                {
                    //Console.WriteLine("- Pedido: " + pedido.TipoRamo + " Cantidad " + pedido.Cantidad);
                    listaPedidosSinStock.Add(pedido);
                }

            }

            //si no hay stock para el pedido, se agrega a la lista de pedidos sin stock
        }
    }
}

