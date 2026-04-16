namespace GestionaleRistorante.Data
{
    public class Cliente
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateOnly DataNascita {  get; set; }
        public List<Ordine> Ordini = [];
        public List<Prodotto> Prodotti = [];
    }
}
