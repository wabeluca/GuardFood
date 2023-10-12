using GuardFood.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using GuardFood.Infrastructure.Data.Interfaces;
using Newtonsoft.Json;

namespace GuardFood.Api.Controllers
{
    [Route("pedido")]
    public class PedidoController : MainController
    {
        private readonly IPedidoRepository _pedidoRepository;
        public PedidoController(IPedidoRepository pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        [HttpGet]
        [Route("todos")]
        public IActionResult BuscarTodos()
        {
            var pedidos = _pedidoRepository.BuscarTodos();
            return Ok(pedidos);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult BuscarPedidoPorId(Guid id)
        {
            return Ok();
        }

        [HttpPost]
        [Route("inserir")]
        public async Task<IActionResult> Inserir()
        {
            try
            {
                var descricao = Request.Form["descricao"];

                var denuncia = new Pedido();
                denuncia.Descricao = descricao;
                denuncia.Alteracao = DateTime.Now;
                denuncia.Inclusao = DateTime.Now;

                _pedidoRepository.Inserir(denuncia);

                return Ok("Formulário recebido com sucesso.");
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao processar o formulário.");
            }
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
