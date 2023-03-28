using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBanco
{
    class Cliente
    {
        private int id;
        private string rut;
        private string nombre;
        private int clienteTipoid;
        private bool activo;

        public Cliente(int _id, string _rut, string _nombre, int _clienteTipoId) {
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

        public int getSaldoTotal(Cuenta[] listaCuentas, int _clienteId, int _bancoId)
        {
            int saldo = 0;
            //cuales son todas sus cuentas?
            for(int i=0; i<listaCuentas.Length; i++)
            {
                //recorro todas las cuentas
                if(_clienteId == listaCuentas[i].getClienteId() && _bancoId == listaCuentas[i].getBancoId())
                {
                    //Console.WriteLine("DEBUG: " + listaCuentas[i].getClienteId());
                    saldo += listaCuentas[i].getSaldo();
                }
            }
            return saldo;
        }

    }
}
