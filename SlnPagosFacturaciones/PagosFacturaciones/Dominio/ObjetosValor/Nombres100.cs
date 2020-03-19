using PagosFacturaciones.Marco.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace PagosFacturaciones.Dominio.ObjetosValor
{
    public class Nombres100 : Value<Nombres100>
    {
        protected Nombres100() { }
        public string Value { get; set; }
        internal Nombres100(string nombres) => Value = nombres;
        public static Nombres100 FromString(string nombres)
        {
            CheckValidity(nombres);
            return new Nombres100(nombres);
        }

        private static void CheckValidity(string nombres)
        {
            if (string.IsNullOrWhiteSpace(nombres))
                throw new ArgumentException("Nombres no puede estar vacio", nameof(nombres));
            if (nombres.Length > 100)
                throw new ArgumentOutOfRangeException(nameof(nombres), "Nombres no puede tener mas de 100 caracteres");
        }

        public static implicit operator string(Nombres100 nombres) => nombres.Value;
    }
}
