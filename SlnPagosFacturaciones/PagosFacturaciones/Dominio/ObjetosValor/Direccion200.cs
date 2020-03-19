using PagosFacturaciones.Marco.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace PagosFacturaciones.Dominio.ObjetosValor
{
    public class Direccion200 : Value<Direccion200>
    {
        protected Direccion200() { }
        public string Value { get; set; }
        internal Direccion200(string direccion) => Value = direccion;
        public static Direccion200 FromString(string direccion)
        {
            CheckValidity(direccion);
            return new Direccion200(direccion);
        }

        private static void CheckValidity(string direccion)
        {
            if (string.IsNullOrWhiteSpace(direccion))
                throw new ArgumentException("Direccion no puede estar vacio", nameof(direccion));
            if (direccion.Length > 200)
                throw new ArgumentOutOfRangeException(nameof(direccion), "Direccion no puede tener mas de 200 caracteres");
        }

        public static implicit operator string(Direccion200 direccion) => direccion.Value;
    }
}
