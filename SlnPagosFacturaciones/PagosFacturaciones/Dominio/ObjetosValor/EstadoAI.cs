using PagosFacturaciones.Marco.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace PagosFacturaciones.Dominio.ObjetosValor
{
    public class EstadoAI : Value<EstadoAI>
    {
        protected EstadoAI() { }
        public string Value { get; set; }
        internal EstadoAI(string estado) => Value = estado;
        public static EstadoAI FromString(string estado)
        {
            CheckValidity(estado);
            return new EstadoAI(estado);
        }

        private static void CheckValidity(string estado)
        {
            if (string.IsNullOrWhiteSpace(estado))
                throw new ArgumentException("Estado no puede estar vacio", nameof(estado));
            if (!estado.Equals("Activo") && !estado.Equals("Inactivo"))
                throw new ArgumentOutOfRangeException(nameof(estado), "Estado no puede tener otro valor que no sea Activo o Inactivo");
        }

        public static implicit operator string(EstadoAI estado) => estado.Value;
    }
}
