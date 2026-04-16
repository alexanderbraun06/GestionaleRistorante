using GestionaleRistorante.Data;

namespace GestionaleRistorante.Dto
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public List<Ordine> Ordini = [];
        public List<Prodotto> Prodotti = [];
    }
}
