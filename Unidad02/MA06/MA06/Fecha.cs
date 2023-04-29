using System;
namespace MA06
{
    public class Fecha
    {
        private int dia;
        private int mes;
        private int year;

        public Fecha()
        {
        }

        public Fecha(int _dia, int _mes, int _year)
        {
            dia = _dia;
            mes = _mes;
            year = _year;
        }

        public override string ToString()
        {
            return dia + "/" + mes + "/" + year;
        }
    }
}

