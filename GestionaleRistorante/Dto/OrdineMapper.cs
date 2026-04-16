using GestionaleRistorante.Data;

namespace GestionaleRistorante.Dto
{
    public class OrdineMapper
    {
        public OrdineDto MapEntityToDto(Ordine entity)
        {
            return new OrdineDto
            {
                IdOrdine = entity.IdOrdine,
                IdCliente = entity.IdCliente,
                Totale = entity.Totale
            };
        }
    }
}