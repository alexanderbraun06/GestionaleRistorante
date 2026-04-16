using GestionaleRistorante.Data;

namespace GestionaleRistorante.Dto
{
            public class ProdottoMapper
        {
            public Prodotto MapEntityToDto(Prodotto entity)
            {
                if (entity == null)
                    return null;

                return new Prodotto
                {
                    NomeProdotto = entity.NomeProdotto,
                    Prezzo = entity.Prezzo
                };
            }
        }
    }