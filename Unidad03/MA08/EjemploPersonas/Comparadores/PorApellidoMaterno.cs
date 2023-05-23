using System;
using System.Collections;

namespace MA08.EjemploPersonas.Comparadores
{
    public class PorApellidoMaterno : IComparer
    {
        public int Compare(object? _x, object? _y)
        {
            if (_x == null || _y == null)
            {
                return 0;
            }

            if (_x is Persona && _y is Persona)
            {
                Persona p1 = (Persona)_x;
                Persona p2 = (Persona)_y;
                return p1.getApellidoMaterno().CompareTo(p2.getApellidoMaterno());
            }
            else
            {
                throw new ArgumentException("Uno o más objetos NO son PERSONA");
            }
        }
    }
}

