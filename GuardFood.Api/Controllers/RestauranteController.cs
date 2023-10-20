using GuardFood.Core.Entities;
using GuardFood.Infrastructure.Data.Interfaces;
using GuardFood.Infrastructure.Data.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GuardFood.Api.Controllers
{
    [Route("restaurante")]
    public class RestauranteController : MainController
    {
        private readonly IRestauranteRepository _restauranteRepository;
        private readonly IProdutoRepository _produtoRepository;
        public RestauranteController(IRestauranteRepository restauranteRepository, IProdutoRepository produtoRepository)
        {
            _restauranteRepository = restauranteRepository;
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        [Route("todos")]
        public IActionResult BuscarTodos()
        {
            var restaurantes = _restauranteRepository.BuscarTodos();
            return Ok(restaurantes);
        }

        [HttpGet]
        [Route("detalhe/{id}")]
        public IActionResult BuscarPorId(Guid id)
        {
            var produtos = _produtoRepository.BuscarTodos().ToList();
            var pratos = _produtoRepository.BuscarProdutosPorRestaurante(id).ToList();
            var restaurante = _restauranteRepository.BuscarPorId(id);
            var model = new RestauranteProdutoViewModel();

            model.Restaurante = restaurante;
            model.Produtos = pratos;
            model.ProdutosNaoVinculados = produtos;
            
            return Ok(model);
        }

        [HttpPost]
        [Route("inserir")]
        public async Task<IActionResult> Inserir()
        {
            try
            {
                var nome = Request.Form["nome"];
                var descricao = Request.Form["descricao"];
                var corPrimaria = Request.Form["corPrimaria"];
                var corSecundaria = Request.Form["corSecundaria"];
                var anexo = Request.Form.Files["anexo"];
                var base64 = "";

                if (anexo != null && anexo.Length > 0)
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        await anexo.CopyToAsync(memoryStream);
                        var bytes = memoryStream.ToArray();
                        var base64String = Convert.ToBase64String(bytes);
                        base64 = base64String;
                    }
                }

                var restaurante = new Restaurante();
                restaurante.Nome = nome;
                restaurante.CorPrimaria = corPrimaria;
                restaurante.CorSecundaria = corSecundaria;
                restaurante.Descricao = descricao;
                restaurante.Logo = "data:image/png;base64," + base64;
                restaurante.Alteracao = DateTime.Now;
                restaurante.Inclusao = DateTime.Now;

                _restauranteRepository.Inserir(restaurante);

                return Ok("Formulário recebido com sucesso.");
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao processar o formulário.");
            }
        }

        [HttpPost]
        [Route("atualizar")]
        public IActionResult Atualizar()
        {
            try
            {
                var id = Guid.Parse(Request?.Form["id"]);
                
                var restaurante = _restauranteRepository.BuscarPorId(id);

                restaurante.Nome = Request?.Form["nome"];
                restaurante.Descricao = Request?.Form["descricao"];
                restaurante.CorPrimaria = Request?.Form["corPrimaria"];
                restaurante.CorSecundaria = Request?.Form["corSecundaria"];
                restaurante.Alteracao = DateTime.Now;

                bool sucesso = _restauranteRepository.Editar(restaurante);

                if (sucesso)
                {
                    return Ok("Restaurante atualizado com sucesso");
                }
                else
                {
                    return NotFound("Restaurante não encontrado");
                }
            }
            catch (JsonException)
            {
                return BadRequest("JSON inválido");
            }
        }

        [HttpGet]
        [Route("deletar/{id}")]
        public IActionResult Deletar(Guid id)
        {
            var sucesso = _restauranteRepository.Deletar(id);
            
            if (sucesso)
                return Ok();
            
            return BadRequest("Nenhum restaurante encontrado!");   
        }
        
        [HttpGet]
        [Route("desvincular")]
        public IActionResult Desvincular(Guid restauranteId, Guid produtoId)
        {
            var sucesso = _produtoRepository.Desvincular(restauranteId, produtoId);
            
            if (sucesso)
                return Ok();
            
            return BadRequest("Nenhum produto vinculado encontrado!");   
        }

        [HttpGet]
        [Route("vincular")]
        public IActionResult Vincular(Guid restauranteId, Guid produtoId)
        {
            var sucesso = _produtoRepository.Vincular(restauranteId, produtoId);
            
            if (sucesso)
                return Ok();
            
            return BadRequest("Nenhum produto vinculado encontrado!");   
        }
    }
}
