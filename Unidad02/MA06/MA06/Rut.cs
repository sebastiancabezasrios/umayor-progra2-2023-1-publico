using System;
namespace MA06
{
    public class Rut
    {
        private int numero;
        private char dv;

        public Rut()
        {
            numero = 0;
            dv = 'X';
        }

        public Rut(int _numero, char _dv)
        {
            numero = _numero;
            dv = _dv;
        }

        public override string ToString()
        {
            return numero + "-" + dv;
        }
    }
}

