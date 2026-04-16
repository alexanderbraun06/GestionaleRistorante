using GestionaleRistorante.Data;

namespace GestionaleRistorante.Dto
{
    public class OrdineDto
    {
        public int IdOrdine { get; set; }
        public int IdCliente { get; set; }
        public double Totale { get; set; }
        public List<Ordine> Ordini = [];
    }
}
