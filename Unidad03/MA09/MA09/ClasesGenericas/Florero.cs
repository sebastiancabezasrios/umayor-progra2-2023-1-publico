using System;
namespace MA09.ClasesGenericas
{
	public class Florero
	{
        private Enumerados.EMaterial _material;

        public Florero()
		{
		}

        public Florero(Enumerados.EMaterial _material)
        {
            this._material = _material;
        }

        public override string ToString()
        {
            return _material.ToString();
        }
    }
}

