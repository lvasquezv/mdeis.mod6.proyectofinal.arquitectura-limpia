using System;
using System.Collections.Generic;
using System.Text;

namespace PagosFacturaciones.Dominio.Entidad
{
    public class FacturaItem
    {
        public Factura Factura { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }
        public float MontoParcial { get; set; }
    }
}
