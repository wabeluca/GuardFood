using GuardFood.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using GuardFood.Infrastructure.Data.Interfaces;
using Newtonsoft.Json;

namespace GuardFood.Api.Controllers
{
    [Route("pedido")]
    public class PedidoController : Controller
    {
        public PedidoController()
        {
        }

        [HttpGet]
        [Route("todos")]
        public IActionResult BuscarTodos()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult BuscarPedidoPorId(Guid id)
        {
            return Ok();
        }

        [HttpPost]
        [Route("inserir")]
        public IActionResult InserirPedido([FromBody] Pedido pedido)
        {
            return Ok();
        }

        [HttpPut]
        [Route("atualizar/{id}")]
        public IActionResult AtualizarPedido(Guid id, [FromBody] Pedido pedido)
        {
            return Ok();
        }

        [HttpDelete]
        [Route("deletar/{id}")]
        public IActionResult DeletarPedido(Guid id)
        {
            return Ok();
        }
    }
}
