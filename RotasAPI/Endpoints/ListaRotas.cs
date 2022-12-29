using Microsoft.AspNetCore.Mvc;
using RotasApi.Entities;
using RotasApi.Repository;

namespace RotasApi.Endpoints
{
    public class ListaRotas
    {
        public static string Parametro => "/rotas";
        public static string[] Metodo => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Func => Acao;

        public static IResult Acao()
        {
            RotaRepository rotas = new RotaRepository();
            rotas.Carga();

            List<Rota> listaRotas = RotaRepository.BancoDeDados.ToList();

            if (listaRotas != null)
            {
                return Results.Ok(listaRotas);
            }
            else
            {
                return Results.NotFound();
            }

        }
    }

}
