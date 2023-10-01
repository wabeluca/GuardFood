using GuardFood.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GuardFood.Api.Controllers
{
    public class RestauranteController : Controller
    {
        private readonly IRestauranteRepository _restauranteRepository;
        public RestauranteController(IRestauranteRepository restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }

        public IActionResult Inserir(string json)
        {
            var objeto = JsonConvert.DeserializeObject<Restaurante>(json);


            return Ok();
        }
    }
}
