using RotasApi.Entities;

namespace RotasApi.Repository
{
    public class RotaRepository
    {
        public static List<Rota> BancoDeDados { get; set; } = new List<Rota>();

        public void Carga()
        {

            // le o arquivo fixo no c:\temp
            StreamReader csv = new StreamReader(@"c:\Temp\Rotas.csv");
            string linha;
            string[] campo;
            int i=1;

            while ((linha = csv.ReadLine()) != null)
            {
                campo = linha.Split(',');
                Rota rotaNew = new Rota(i++, campo[0], campo[1], Int16.Parse(campo[2]));
                BancoDeDados.Add(rotaNew);
            }

        }
    }
}
