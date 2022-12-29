using Microsoft.AspNetCore.Mvc;
using RotasApi.Entities;
using RotasApi.Repository;

namespace RotasApi.Endpoints
{
    
    public class AcharRota
    {
        public static string Parametro => "/rota/{id:int}";
        public static string[] Metodo => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Func => Acao;

        public static IResult Acao([FromRoute] int id)
        {
            RotaRepository rotaCarga = new RotaRepository();
            rotaCarga.Carga();

            Rota rotaEcontrada = RotaRepository.BancoDeDados.FirstOrDefault(a => a.Id.Equals(id));

            if(rotaEcontrada != null)
            {
                return Results.Ok(rotaEcontrada);
            }
            else
            {
                return Results.NotFound();
            }
        }
    }

}
