using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBanco
{
    class Cuenta
    {
        private int id;
        private string numero;
        private int clienteId;
        private int cuentaTipoId;
        private int saldo;
        private int bancoId;
        private bool activo;

        public Cuenta(int _id, string _numero, int _clienteId, int _bancoId, int _cuentaTipoId,int _saldo)
        {
            id = _id;
            numero = _numero;   
            clienteId = _clienteId;
            bancoId = _bancoId;
            saldo = _saldo;
            cuentaTipoId = _cuentaTipoId;
        }

        //accesadores
        public string getNumeroCuenta()
        {
            return numero;
        }
        public int getSaldo()
        {
            return saldo;
        }

        public int getClienteId()
        {
            return clienteId;
        }

        public int getBancoId()
        {
            return bancoId;
        }

    }
}
