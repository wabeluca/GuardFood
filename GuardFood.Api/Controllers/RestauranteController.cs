using GuardFood.Core.Entities;
using GuardFood.Infrastructure.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GuardFood.Api.Controllers
{
    [Route("restaurante")]
    public class RestauranteController : Controller
    {
        private readonly IRestauranteRepository _restauranteRepository;
        public RestauranteController(IRestauranteRepository restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }

        [HttpGet]
        [Route("todos")]
        public IActionResult BuscarTodos()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult BuscarPorId(Guid id)
        {
            return Ok();
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult Inserir(string json)
        {
            var objeto = JsonConvert.DeserializeObject<Restaurante>(json);


            return Ok();
        }

        [HttpPut]
        [Route("atualizar")]
        public IActionResult Atualizar(Guid id, string json)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult Deletar(Guid id)
        {
            return Ok();
        }
    }
}
