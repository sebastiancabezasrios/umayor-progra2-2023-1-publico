using System;
namespace MA06
{
	public class App
	{
		public static void Main_()
		{
			Persona per1 = new Persona(new Rut(16444555, '2'), "Luz Maria", "Jara Lara", 'F', 'S', new Fecha(10, 12, 1982));
			Persona per2 = new Persona(new Rut(14555666, '6'), "Juan", "Lopez", 'M', 'C', new Fecha(26, 5, 1980));

			Empleado emp1 = new Empleado(per1, 750000);
            Empleado emp2 = new Empleado(per2, 150000);

            Administrativo adm1 = new Administrativo(emp1, new Jornada(true), 0.15);
            Administrativo adm2 = new Administrativo(emp2, new Jornada(false), 0.35);

            Docente doc1 = new Docente(emp2, 10, "Doctor");

            Console.WriteLine("out1: " + per1.ToString());
			Console.WriteLine("out2: " + emp1.ToString());
			Console.WriteLine("out3: " + adm1.ToString());

            Console.WriteLine("out4: " + per2.ToString());
            Console.WriteLine("out5: " + emp2.ToString());
            Console.WriteLine("out6: " + adm2.ToString());

            Console.WriteLine("out7: " + doc1.ToString());

            if (adm1 is Administrativo)
            {
                Console.WriteLine("es administrativo");
                Administrativo ad2 = (Administrativo) adm1;
                Console.WriteLine("ad2: " + ad2.ToString());

            }
            else
            {
                Console.WriteLine("NO es administrativo");

            }

            Console.WriteLine("quien soy per: " + per1.quienSoy());
            Console.WriteLine("quien soy emp: " + emp1.quienSoy());
            Console.WriteLine("quien soy adm: " + adm1.quienSoy());
            Console.WriteLine("quien soy doc: " + doc1.quienSoy());

        }
    }
}

