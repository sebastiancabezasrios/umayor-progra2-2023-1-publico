
using System;
namespace Modulo03
{
	public class RUT
	{
		private string rut;

		//constructor por defecto
		public RUT() //A
		{
			rut = "0-0";
		}
        //constructor por parametros // B
        public RUT(string _rut)
        {
			bool resultado = validarFormato(_rut);
            Console.WriteLine("Es valido? ["+_rut+"] : "+resultado);
			if (validarFormato(_rut))
            {
				rut = _rut;
			}
			else
			{
				rut = "0-0";
			}
        }
		//constructor con sobrecarga // C
		public RUT (int _run)
		{
			//Console.WriteLine("RUN: " + _run + "-" + getDV(_run));
			if (_run == 11111111)
			{
				rut = "0-0";
			}
			else
			{
				rut = _run + "-" + getDV(_run);

            }
		}
		//D
		public RUT (RUT _rut)
		{
			rut = _rut.getRut();
		}
		//F
		public string getRut()
		{
			return rut;
		}
        public void setRut(string _rut)
        {
            rut = _rut;
        }

        //funciones propias
        private bool validarFormato(string _rut)
		{
			if(_rut.Length >= 9 && _rut.Length <= 13)
			{
				//primero que todo... obviar el punto... o saltarselo: lo reemplazamos
				_rut = _rut.Replace(".","");
				//Console.WriteLine("Sin puntos?: " + _rut);
				//segundo que todo... separar numerico de dv
                string[] datos = _rut.Split('-');
				//[0]: numerico
				//[1]: numeros+k
				//tercero trabajamos la parte numerica
				int numerico;
				if(!int.TryParse(datos[0], out numerico))
				{
					return false;
				}
                //cuarto trabajamos la parte del dv
                datos[1] = datos[1].ToLower();
				//lo valido si es un numero
                if (int.TryParse(datos[1], out numerico))
                {
					return true;
				}
				else
				{
					//si es falso, entonces no es un numero y compruebo q es k
					if (datos[1] == "k")
					{
						return true;
					}

                }
                //Console.WriteLine("El rut: " + datos[0] + "-" + datos[1]);
            }
			return false;
		}

		private string getDV(int _run) // C
		{
			string runString = "" + _run;
			int longitud = runString.Length;
            string runInvertido = "";

			for(int j = longitud-1; j >= 0; j--)
			{
				runInvertido += runString[j];
            }


            char charRutInver;
            int p = 0;
            int z = 2;
            int multi = 0, suma = 0, intMul;
            double intDiv, intResiduo;

            for (; p < longitud; z++)
            {
				if (p != -1)
				{

                    /*
					if(z <= 7)
					{
                        charRutInver = runInvertido[p];
                        intMul = Convert.ToInt32(new string(charRutInver, 1));
                        multi = intMul * z;
                        suma = suma + multi;
					}
					else
					{
                        z = 2;
                        charRutInver = runInvertido[p];
                        intMul = Convert.ToInt32(new string(charRutInver, 1));
                        multi = intMul * z;
                        suma = suma + multi;
                    }*/
                    if (z > 7)
                    {
                        z = 2;
                    }
                    charRutInver = runInvertido[p];
                    intMul = Convert.ToInt32(new string(charRutInver, 1));
                    multi = intMul * z;
                    suma = suma + multi;
                    p++;
				}
            }
            intDiv = suma / 11;
            intResiduo = suma % 11;
            bool checkeo = (((intDiv * 11) + intResiduo) == suma);
            //bool checkDV = (11 - intResiduo == intDV);
            double intRestaDV = (11 - intResiduo);
			if (intRestaDV == 10)
			{
				return "K";
			}
			else if (intRestaDV == 11)
			{
				return "0";
			}
			else
			{
				return intRestaDV.ToString();
            }
		}


		private bool esValido(int _run, int _dv)// G
		{
			if (_dv.ToString() == getDV(_run))
			{
				return true;
			}
			return false;
		}

        public override string ToString()
        {
			return rut;
        }
    }
}

