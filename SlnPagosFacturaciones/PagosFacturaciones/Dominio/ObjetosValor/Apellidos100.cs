using PagosFacturaciones.Marco.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace PagosFacturaciones.Dominio.ObjetosValor
{
    public class Apellidos100 : Value<Apellidos100>
    {
        protected Apellidos100() { }
        public string Value { get; set; }
        internal Apellidos100(string apellidos) => Value = apellidos;
        public static Apellidos100 FromString(string apellidos)
        {
            CheckValidity(apellidos);
            return new Apellidos100(apellidos);
        }

        private static void CheckValidity(string apellidos)
        {
            if (string.IsNullOrWhiteSpace(apellidos))
                throw new ArgumentException("Apellidos no puede estar vacio", nameof(apellidos));
            if (apellidos.Length > 100)
                throw new ArgumentOutOfRangeException(nameof(apellidos), "Apellidos no puede tener mas de 100 caracteres");
        }

        public static implicit operator string(Apellidos100 apellidos) => apellidos.Value;
    }
}
