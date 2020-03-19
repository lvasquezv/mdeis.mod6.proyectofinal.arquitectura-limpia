using System;
using System.Collections.Generic;
using System.Text;

namespace PagosFacturaciones.Dominio.Excepciones
{
    public class FacturaInvalidEntityException : Exception
    {
        public FacturaInvalidEntityException(object entity, string message)
            : base($"Entidad {entity.GetType().Name} cambio de estado rechazado, {message}")
        {
        }
    }
}
