using System;
using System.Collections.Generic;
using System.Text;

namespace PagosFacturaciones.Dominio.Entidad
{
    public class Pago
    {
        public Cliente Cliente { get; set; }
        public Factura Factura { get; set; }
        public FormaDePago FormaDePago { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Estado { get; set; }
    }
}
