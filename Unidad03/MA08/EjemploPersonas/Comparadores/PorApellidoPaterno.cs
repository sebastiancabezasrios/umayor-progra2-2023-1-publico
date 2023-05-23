using System;
using System.Collections;

namespace MA08.EjemploPersonas.Comparadores
{
    public class PorApellidoPaterno : IComparer
    {
        public int Compare(object? _x, object? _y)
        {
            if (_x == null || _y == null)
            {
                return 0;
            }

            if(_x is Persona && _y is Persona)
            {
                Persona p1 = (Persona)_x;
                Persona p2 = (Persona)_y;
                //Console.WriteLine("Estamos comparando objetos");
                //Console.WriteLine("[" + p1.ToString() + "] y [" + p2.ToString() + "]");
                return p1.getApellidoPaterno().CompareTo(p2.getApellidoPaterno());
                //return -99;
            }
            else
            {
                throw new ArgumentException("Uno o más objetos NO son PERSONA");
            }
        }
    }
}

