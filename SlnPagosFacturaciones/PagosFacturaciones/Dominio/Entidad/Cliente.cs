using PagosFacturaciones.Dominio.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace PagosFacturaciones.Dominio.Entidad
{
    public class Cliente
    {
        public Nit Nit { get; set; }
        public Nombres100 Nombres { get; set; }
        public Apellidos100 Apellidos { get; set; }
        public Direccion200 Direccion { get; set; }
        public EstadoAI Estado { get; set; }


    }
}
