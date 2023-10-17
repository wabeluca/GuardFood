using GuardFood.Core.Entities;
using GuardFood.Infrastructure.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GuardFood.Api.Controllers;

public class ProdutoController : MainController
{
    private readonly IProdutoRepository _produtoRepository;
    public ProdutoController(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    [HttpGet]
    [Route("todos")]
    public IActionResult BuscarTodos()
    {
        var produtos = _produtoRepository.BuscarTodos();
        return Ok(produtos);
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
            var nome = Request.Form["nome"];
            var descricao = Request.Form["descricao"];
            var valor = Request.Form["valor"];
            
            var produto = new Produto();
            
            produto.Nome = nome;
            produto.Descricao = descricao;
            produto.Valor = Double.Parse(valor);
            produto.Alteracao = DateTime.Now;
            produto.Inclusao = DateTime.Now;

            _produtoRepository.Inserir(produto);

            return Ok("Formulário recebido com sucesso.");
        }
        catch (Exception)
        {
            return StatusCode(500, "Erro ao processar o formulário.");
        }
    }

    [HttpPut]
    [Route("atualizar/{id}")]
    public IActionResult AtualizarPedido(Guid id, [FromBody] Produto pedido)
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