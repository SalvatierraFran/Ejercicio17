using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio17
{
    class Cuenta
    {
        private string _nombre;
        private long _nroCuenta;
        private double _saldo;
        private Enumerados.ETipoInteres _tipoInteres;

        public Cuenta(string Nombre, long NroCuenta, double Saldo, Enumerados.ETipoInteres TipoInteres)
        {
            this._nombre = Nombre;
            this._nroCuenta = NroCuenta;
            this._saldo = Saldo;
            this._tipoInteres = TipoInteres;
        }

        public string getNombre()
        {
            return this._nombre;
        }

        public long getNroCuenta()
        {
            return this._nroCuenta;
        }

        public double getSaldo()
        {
            return this._saldo;
        }

        public Enumerados.ETipoInteres getTipoInteres()
        {
            return this._tipoInteres;
        }

        public void setNombre(string Nombre)
        {
            this._nombre = Nombre;
        }

        public void SetNroCuenta(long NroCuenta)
        {
            this._nroCuenta = NroCuenta;
        }

        public void setSaldo(double saldo)
        {
            this._saldo = saldo;
        }

        public void setTipoInteres(Enumerados.ETipoInteres tipoInteres)
        {
            this._tipoInteres = tipoInteres;
        }
    }
}

namespace Enumerados
{
    public enum ETipoInteres
    {
        TIN, TAE, TIR
    }
}
