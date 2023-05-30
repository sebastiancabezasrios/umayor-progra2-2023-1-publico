namespace bibliotecaDeClases;

public class Boleta
{
    private int numero;
    private int monto;
    private DateTime fecha;

    public Boleta()
    {

    }

    public Boleta(int _numero, int _monto, DateTime _fecha)
    {
        numero = _numero;
        monto = _monto;
        fecha = _fecha;
    }

    public override string ToString()
    {
        return "Boleta N[" + numero + "] - Monto $[" + monto + "] - Fecha [" + fecha + "]";
    }
}

