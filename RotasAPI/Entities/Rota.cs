namespace RotasApi.Entities
{
    public class Rota
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public int Valor { get; set; }

        public Rota(int id, string origem, string destino, int valor)
        {
            Id = id;
            Origem = origem;
            Destino = destino;
            Valor = valor;
        }
    }
}
