using PagosFacturaciones.Marco.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace PagosFacturaciones.Dominio.ObjetosValor
{
    public class CodigoControl : Value<CodigoControl>
    {
        protected CodigoControl() { }
        public string Value { get; set; }
        internal CodigoControl(string codigocontrol) => Value = codigocontrol;
        public static CodigoControl FromString(string codigocontrol)
        {
            CheckValidity(codigocontrol);
            return new CodigoControl(codigocontrol);
        }

        private static void CheckValidity(string codigocontrol)
        {
            if (string.IsNullOrWhiteSpace(codigocontrol))
                throw new ArgumentException("Nombres no puede estar vacio", nameof(codigocontrol));
            if (codigocontrol.Length > 10)
                throw new ArgumentOutOfRangeException(nameof(codigocontrol), "Codigo de Control no puede tener mas de 10 caracteres");
        }

        public static implicit operator string(CodigoControl codigocontrol) => codigocontrol.Value;
    }
}
