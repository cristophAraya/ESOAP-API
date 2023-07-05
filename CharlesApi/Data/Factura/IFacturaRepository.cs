using CharlesApi.Entities.Factura;

namespace CharlesApi.Repository.Factura
{
    public interface IFacturaRepository
    {
        public FacturaModel CrearFactura(FacturaModel facturaModel);
    }
}