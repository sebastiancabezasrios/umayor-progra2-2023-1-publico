using System;
using MA09.EjemploCajas;

namespace MA09
{
	public class App
	{
		//metodo estatico para saber los datos de la caja
		public static void verificarCajaCelular(Caja<Celular> _caja, string _nombreCaja)
		{
            if (_caja.estaVacia())
            {
				Console.WriteLine("La " + _nombreCaja + " está vacía");
            }
            else
            {
                Console.WriteLine("Contenido de la " + _nombreCaja);
                Console.WriteLine(_caja.ToString());
            }
        }

        public static void verificarCajaFlorero(Caja<Florero> _caja, string _nombreCaja)
        {
            if (_caja.estaVacia())
            {
                Console.WriteLine("La " + _nombreCaja + " está vacía");
            }
            else
            {
                Console.WriteLine("Contenido de la " + _nombreCaja);
                Console.WriteLine(_caja.ToString());
            }
        }

        public static void Main()
		{
			Console.WriteLine("MA09 :)");

			Caja<Celular> caja1 = new Caja<Celular>(new Celular("Iphone 12", 292929));

			//verificarCajaCelular(caja1, "Caja Uno");
            //caja1.verificarCaja(caja1, "Caja #1"); //mal implementado, pq estamos volviendo a pasar la caja que ya sabemos que tiene, pq ya es una caja
            caja1.verificarCaja("Caja #1");

            Caja<Florero> caja2 = new Caja<Florero>();

            //verificarCajaFlorero(caja2, "Caja Dos");
            caja2.verificarCaja("Caja #2");

            caja2.guardar(new Florero(Enumerados.EMaterial.Cerámica));
            //caja2.guardar(new Florero(Enumerados.EMaterial.Vidrio));

            //verificarCajaFlorero(caja2, "Caja Dos");
            caja2.verificarCaja(caja2, "Caja #2");
            caja2.verificarCaja("Caja #2");


        }
    }
}

