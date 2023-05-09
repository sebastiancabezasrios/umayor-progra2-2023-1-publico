using System;
namespace MA06
{
	public class App07
	{
		public static void Main()
		{
            Persona per1 = new Persona(new Rut(11222333, '2'), "Luz Maria", "Jara Lara", 'F', 'S', new Fecha(10, 12, 1982));
            Persona per2 = new Persona(new Rut(22333444, '6'), "Juan", "Lopez", 'M', 'C', new Fecha(26, 5, 1980));
            Persona per3 = new Persona(new Rut(12312311, '6'), "Pedrito", "Fernandez", 'M', 'S', new Fecha(26, 5, 1980));

            Empleado emp1 = new Empleado(per1, 750000);
            Empleado emp2 = new Empleado(per2, 150000);
            Empleado emp3 = new Empleado(per3, 150000);

            Administrativo adm1 = new Administrativo(emp1, EJornada.Completa, 0.1);
            Empleado empleadoCoercion;
            empleadoCoercion = new Administrativo(per2, EJornada.Media, 0.2);

            Console.WriteLine("ADM1: "+adm1.ToString());
            Console.WriteLine("EmpleadoCoercion: " + empleadoCoercion.ToString());
            Console.WriteLine("EmpleadoCoercion Sueldo: $" + empleadoCoercion.getSueldo());
            double valor;
            valor = emp2.getSueldo();
            Console.WriteLine("Sueldo del Empleado 2: $" + valor);

            List<Empleado> nomina = new List<Empleado>();
            List<string> listaPalabras = new List<string>();
            List<Object> listaObjetos = new List<Object>();

            Console.WriteLine("Cantidad de Empleados: [" + nomina.Count() + "]");
            nomina.Add(emp1);
            nomina.Add(emp2);
            nomina.Add(emp3);
            Console.WriteLine("Cantidad de Empleados: [" + nomina.Count() + "]");


            Console.WriteLine("Cantidad de Palabras: [" + listaPalabras.Count() + "]");
            listaPalabras.Add("Hola");
            listaPalabras.Add("Mundo");
            listaPalabras.Add("Universidad");
            listaPalabras.Add("Mayor");
            Console.WriteLine("Cantidad de Palabras: [" + listaPalabras.Count() + "]");

            Console.WriteLine("Cantidad de Objetos: [" + listaObjetos.Count() + "]");
            listaObjetos.Add(emp1);
            listaObjetos.Add("Programacion en C# agilada");
            listaObjetos.Add(per1);
            listaObjetos.Add(1980);
            listaObjetos.Add(true);
            Console.WriteLine("Cantidad de Objetos: [" + listaObjetos.Count() + "]");

            foreach (Object item in listaObjetos)
            {
                if (item is Empleado)
                {
                    //castear si es empleado
                    Console.WriteLine("$" + ((Empleado)item).getSueldo());
                }
                else if (item is Persona)
                {
                    Console.WriteLine(">" + ((Persona)item).getRut());
                }
                else
                {
                    Console.WriteLine("#" + item.ToString());
                }
            }

            //Console.WriteLine("Persona con Where: " + nomina.Where(e => e.getGenero() == 'F'));
            foreach (Empleado item in nomina.Where(e => e.getEstadoCivil() == 'S'))
            {
                Console.WriteLine("Este empleado es de estado civil s: " + item.getNombreApellido());
            }

            //foreach (Object item in listaPalabras)
            //{
            //    if (item is string)
            //    {
            //        Console.WriteLine(">" + ((string)item).ToUpper());
            //    }
            //}
            //foreach (string item in listaPalabras)
            //{
            //    Console.WriteLine(">" + item.ToUpper());
            //}

            ////si no sabes el tipo de datos, ocupa Object: pesima practica, ojala nunca ocupar
            //foreach (Object item in nomina)
            //{
            //    if (item is Empleado)
            //    {
            //        //casteo explicito al tipo de dato abstracto Empleado, donde llama a la funcion getNombreApellido
            //        Console.WriteLine(">" + ((Empleado)item).getNombreApellido());
            //    }
            //}

            //foreach (Empleado item in nomina)
            //{
            //    //casteo explicito al tipo de dato abstracto Empleado, donde llama a la funcion getNombreApellido
            //    Console.WriteLine(">" + item.getNombreApellido());
            //}
            ////Console.WriteLine("Cantidad de Empleados: [" + nomina.Count() + "]");
            ////Console.WriteLine("Cantidad de Empleados: [" + nomina.Count() + "]");
            ///

            Console.WriteLine("Virtual");
            Console.WriteLine("Virtual 1: " + per1.quienSoy());
            Console.WriteLine("Virtual 2: " + emp1.quienSoy());
            Console.WriteLine("Virtual 3: " + adm1.quienSoy());
        }
    }
}

