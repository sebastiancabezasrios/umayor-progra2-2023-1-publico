using System;
namespace MA08
{
	public class AppFiguras
	{
		public static void Main_()
		{
			Console.WriteLine("Hola Unidad 03");
			probandoPuntos();
		}

		public static void probandoPuntos()
		{
			
			Punto punto1 = new Punto();
			Console.WriteLine("Punto 1: " + punto1.ToString());

			Punto punto2 = new Punto(3,8);
            Console.WriteLine("Punto 2: " + punto2.ToString());

            Punto punto3 = new Punto(3, 2);
            Console.WriteLine("Punto 3: " + punto3.ToString());

            Punto punto4 = new Punto(3, 8);
            Console.WriteLine("Punto 4: " + punto4.ToString());
			

			/*
			//Parentesis
			int[] arreglo = { 1, 6, 0, 8, 3 };

            Console.WriteLine("Arreglo Original");
            foreach (var item in arreglo)
			{
				Console.Write("["+item+"]");
			}
			Console.WriteLine();

			//ordenamiento
			Array.Sort(arreglo);

			Console.WriteLine("Arreglo Ordenado Ascendentemente");
            foreach (var item in arreglo)
            {
                Console.Write("[" + item + "]");
            }
            Console.WriteLine();

			Console.WriteLine("Arreglo Ordenado Descendentemente");
			Array.Reverse(arreglo);
            foreach (var item in arreglo)
            {
                Console.Write("[" + item + "]");
            }
            Console.WriteLine();
			*/


			/*
			if (punto1.CompareTo(punto2) == 0)
			{
				Console.WriteLine(punto1.ToString() + " y " + punto2.ToString() + " Son Iguales");
			}
			else if(punto1.CompareTo(punto2) < 0)
			{
                Console.WriteLine(punto1.ToString() + " es MENOR que " + punto2.ToString());
			}
			else
			{
                Console.WriteLine(punto1.ToString() + " es MAYOR que " + punto2.ToString());
            }
			*/

			//pagina 7 de 32
			Punto[] misPuntos = new Punto[5];
			misPuntos[0] = punto2;
			misPuntos[1] = punto3;
            misPuntos[2] = punto4;
            misPuntos[3] = punto1;
			misPuntos[4] = new Punto(2,1);

			OtroObjeto otro = new OtroObjeto();
			try
			{
				if(punto1.CompareTo(otro) == 0)
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

