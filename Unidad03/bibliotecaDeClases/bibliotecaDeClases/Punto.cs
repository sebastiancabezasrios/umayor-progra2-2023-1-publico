using System;
namespace bibliotecaDeClases
{
    public class Punto : IComparable
    {
        private int ejeX;
        private int ejeY;

        public Punto()
        {
            ejeX = 0;
            ejeY = 0;
        }
        public Punto(int _x, int _y)
        {
            ejeX = _x;
            ejeY = _y;
        }

        public int CompareTo(object _obj)
        {
            if (_obj == null)
            {
                return -1;
            }

            if (!(_obj is Punto))
            {
                throw new ArgumentException("El objeto no es un Punto");
            }
            //castea a que sea un Punto que es el objeto que llega por parametro
            Punto p = (Punto)_obj;

            if (this.ejeX == p.ejeX && this.ejeY == p.ejeY)
            {
                return 0;//son iguales
            }
            else if (this.ejeX == p.ejeX && this.ejeY < p.ejeY)
            {
                return -1; //cualquier valor < 0
            }
            else if (this.ejeX == p.ejeX && this.ejeY > p.ejeY)
            {
                return 1; //cualquier valor > 0
            }
            //se usara solo el valor del eje x para discernir
            else if (this.ejeX < p.ejeX)
            {
                return -1; //cualquier valor < 0
            }
            else
            {
                return 1; //cualquier valor > 0
            }
            //throw new NotImplementedException();
        }

        public override string ToString()
        {
            return ejeX + "," + ejeY;
        }
    }
}

