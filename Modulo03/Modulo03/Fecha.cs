using System;
namespace Modulo03
{
	public class Fecha
	{
		private byte dia;
        private byte mes;
		private short year;

        //A
        public Fecha()
		{
            string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
			string[] strDate = date.Split('-');
			//Console.WriteLine("The current date is {0}", date);
			byte.TryParse(strDate[0], out dia);
            byte.TryParse(strDate[1], out mes);
            short.TryParse(strDate[2], out year);
        }
        //B
		public Fecha(string _fecha)
		{
			string [] strFecha = _fecha.Split("/");
            byte dia_, mes_;
            short year_;
            byte.TryParse(strFecha[0], out dia_);
            byte.TryParse(strFecha[1], out mes_);
            short.TryParse(strFecha[2], out year_);

            if(dia_ >= 1 && dia_ <= 31)
            {
                dia = dia_;
            }
            if(mes_ >= 1 && mes_ <= 12)
            {
                mes = mes_;
            }
            if(year_ >= 1900 && year_ <= 2023)
            {
                year = year_;
            }
        }
        //C
        public Fecha(byte _dia, byte _mes, short _year)
        {
            dia = _dia;
            mes = _mes;
            year = _year;
        }
        //D
        public Fecha(Fecha _fecha)
        {
            dia = _fecha.dia;
            mes = _fecha.mes;
            year = _fecha.year;
        }
        //E
        override public string ToString()
        {
            return dia + "/" + mes + "/" + year;
        }
        //F
        public byte Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public byte Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        public short Year
        {
            get { return year; }
            set { year = value; }
        }
        //G
        public bool esBisiesto()
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else
            {
                if(year % 4 == 0 && year % 100 !=0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

