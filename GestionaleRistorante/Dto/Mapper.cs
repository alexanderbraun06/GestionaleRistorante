using GestionaleRistorante.Data;

namespace GestionaleRistorante.Dto
{
    public class Mapper
    {
        public ClienteDto MapBaseEntityToDto(Cliente entity)
        {
            ClienteDto dto = new ClienteDto()
            {
                Id = entity.Id,
                IdCliente = entity.IdCliente,
                Nome = entity.Nome,
                Cognome = entity.Cognome
            };
            return dto;
        }
    }
}