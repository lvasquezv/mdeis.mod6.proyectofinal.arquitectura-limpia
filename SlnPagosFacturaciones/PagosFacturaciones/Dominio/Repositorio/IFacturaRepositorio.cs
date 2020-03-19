using PagosFacturaciones.Dominio.Entidad;
using PagosFacturaciones.Dominio.ObjetosValor;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PagosFacturaciones.Dominio.Repositorio
{
    interface IFacturaRepositorio
    {
        Task<Factura> Load(CodigoControl id);
        Task Add(Factura entity);
        Task Delete(CodigoControl id);
        void Update(Factura entity);
        Task<bool> Exists(CodigoControl id);
    }
}
