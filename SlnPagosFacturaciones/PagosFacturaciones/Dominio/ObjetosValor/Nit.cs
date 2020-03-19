using PagosFacturaciones.Marco.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace PagosFacturaciones.Dominio.ObjetosValor
{
    public class Nit : Value<Nit>
    {
        public int Value { get; set; }
        protected Nit() { }
        public Nit(int nit)
        {
            if (nit == -1)
                throw new ArgumentNullException(nameof(nit), "El Nit no puede tener el valor por defecto");
            Value = nit;
        }

        public static implicit operator int(Nit nit) => nit.Value;

        public static implicit operator Nit(int nit) => new Nit(nit);

        public static implicit operator Nit(string nit)
            => new Nit(int.Parse(nit));
    }
}
