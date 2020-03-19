using System;
using System.Collections.Generic;
using System.Text;

namespace PagosFacturaciones.Dominio.Eventos.Facturas
{
    public class FacturaCreada
    {
        public string CodigoControl { get; set; }
        public string NitCliente { get; set; }
        public int Nro { get; set; }
        public double NroAutorizacion { get; set; }
        public DateTime Fecha { get; set; }
        public float MontoTotal { get; set; }
        public string Estado { get; set; }
        public string CodigoFormaDePago { get; set; }

        public FacturaCreada() { }

    }
}
