using System;

namespace EjercicioBanco
{
	public class Cliente
	{
        private int id;
        private string rut;
        private string nombre;
        private int clienteTipoid;
        private bool activo;

        public Cliente()
        {
            id = 0;
            rut = string.Empty;
            clienteTipoid = 0;
            activo = false;
        }

        public Cliente(int _id, string _rut, string _nombre, int _clienteTipoId)
        {
            id = _id;
            rut = _rut;
            nombre = _nombre;
            clienteTipoid = _clienteTipoId;
            activo = true;
        }

        public int getId() { return id; }
        public string getRut() { return rut; }
        public string getNombre() { return nombre; }
        public int getClienteTipoId() { return clienteTipoid; }
        public bool isActivo() { return activo; }

        public Cliente getClienteById(List<Cliente> _lista, int _id)
        {
            return _lista.Where(l => l.getId().Equals(_id)).First();
            //foreach (Cliente cliente in _lista)
            //{
            //    if (cliente.getId() == _id)
            //    {
            //        return cliente;
            //    }
            //}
            //return null;
        }

        public int getSaldoTotal(List<Cuenta> _lista, int _clienteId, int _bancoId)
        {
            int saldo = 0;
            //cuales son todas sus cuentas?
            foreach (Cuenta cuenta in _lista)
            {
                if(cuenta.getClienteId() == _clienteId && cuenta.getBancoId() == _bancoId)
                {
                    saldo += cuenta.getSaldo();
                }
            }
            return saldo;
        }

    }
}