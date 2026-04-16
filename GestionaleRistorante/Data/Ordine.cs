namespace GestionaleRistorante.Data
{
    public class Ordine
    {
        public int Id { get; set; }
        public int IdOrdine { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public List<Prodotto> Prodotti = [];
        public double Totale { get; set; }
        public object Ordini { get; internal set; }
    }
}
