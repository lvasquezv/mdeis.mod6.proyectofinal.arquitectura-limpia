using PagosFacturaciones.Marco.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace PagosFacturaciones.Dominio.ObjetosValor
{
    public class Codigo50 : Value <Codigo50>
    {
        protected Codigo50() { }
        public string Value { get; set; }
        internal Codigo50(string codigo) => Value = codigo;
        public static Codigo50 FromString(string codigo)
        {
            CheckValidity(codigo);
            return new Codigo50(codigo);
        }

        private static void CheckValidity(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("Codigo no puede estar vacio", nameof(codigo));
            if (codigo.Length > 50)
                throw new ArgumentOutOfRangeException(nameof(codigo), "Codigo no puede tener mas de 50 caracteres");
        }

        public static implicit operator string(Codigo50 codigo) => codigo.Value;
    }
}
