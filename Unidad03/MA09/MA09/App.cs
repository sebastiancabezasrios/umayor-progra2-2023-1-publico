using System;
using MA09.ClasesGenericas;
using bibliotecaDeClases;

namespace MA09
{
	public class App
	{

        private static void probarGenericas()
        {
            Console.WriteLine("Pruebas MA09_001 :)");

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

        public static void Main()
		{
            //probarGenericas();
            Console.WriteLine("No nos interesan las pruebas genericas");
            Caja<Boleta> cajaBoletas0 = new Caja<Boleta>(new Boleta(10, 1000, new DateTime()));
            cajaBoletas0.verificarCaja("Caja de Boletas 0");

            Caja<Boleta> cajaBoletas1 = new Caja<Boleta>();
            cajaBoletas1.verificarCaja("Caja de Boletas 1");
            cajaBoletas1.guardar(new Boleta(20, 2000, new DateTime()));
            cajaBoletas1.verificarCaja("Caja de Boletas 1");

            Console.WriteLine("Este es el contenido Caja de Boletas 2");
            Console.WriteLine(cajaBoletas1.sacar().ToString());

            Punto punto1 = new Punto();
            Console.WriteLine("Punto 1: " + punto1.ToString());

            Punto punto2 = new Punto(3, 8);
            Console.WriteLine("Punto 2: " + punto2.ToString());

            Punto punto3 = new Punto(3, 2);
            Console.WriteLine("Punto 3: " + punto3.ToString());

            Punto punto4 = new Punto(3, 8);
            Console.WriteLine("Punto 4: " + punto4.ToString());

            Punto[] misPuntos = new Punto[5];
            misPuntos[0] = punto2;
            misPuntos[1] = punto3;
            misPuntos[2] = punto4;
            misPuntos[3] = punto1;
            misPuntos[4] = new Punto(2, 1);

            OtroObjeto otro = new OtroObjeto();
            try
            {
                if (punto1.CompareTo(otro) == 0)
                {
                    Console.WriteLine("Son iguales :)");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error, " + ex.ToString());
            }


            Console.WriteLine("Original:");
            mostrarArregloPuntos(misPuntos);

            Array.Sort(misPuntos);
            Console.WriteLine("Puntos ordenados por nuestro criterio");
            mostrarArregloPuntos(misPuntos);
        }

        public static void mostrarArregloPuntos(Punto[] _puntos)
        {
            foreach (Punto item in _puntos)
            {
                Console.WriteLine("(" + item.ToString() + ")");
            }
        }
    }
}

