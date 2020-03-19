using System;
using System.Collections.Generic;
using System.Text;

namespace PagosFacturaciones.Dominio.Entidad
{
    public class Factura
    {
        public string CodigoControl { get; set; }
        public Cliente Cliente { get; set; }
        public int Nro { get; set; }
        public double NroAutorizacion { get; set; }
        public DateTime Fecha { get; set; }
        public float MontoTotal { get; set; }
        public string Estado { get; set; }
        public FormaDePago FormaDePago { get; set; }
    }
}
