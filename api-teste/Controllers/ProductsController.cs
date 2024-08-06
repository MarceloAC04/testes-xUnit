using api_teste.Domains;
using api_teste.Interfaces;
using api_teste.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductsRepository _productsRepository;

        public ProductsController()
        {
                _productsRepository = new ProductsRepository();
        }

        [HttpPost]
        public IActionResult CadastrarProduto(Products product)
        {
            try
            {
                _productsRepository.Cadastrar(product);

                return StatusCode(201, product);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        public IActionResult ListarProdutos()
        {
            try
            {
                List<Products> lista = _productsRepository.Listar();

                return Ok(lista);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet("Id")]
        public IActionResult BuscarPorId(Guid id)
        {
            try
            {
                return Ok(_productsRepository.BuscarPorId(id));

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpDelete("Id")]
        public IActionResult DeletarProduto(Guid id)
        {
            try
            {
                _productsRepository.Deletar(id);

                return StatusCode(201);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        [HttpPut("Id")]
        public IActionResult AtualizarProduto(Guid id, Products produto)
        {
            try
            {
                _productsRepository.Atualizar(id, produto);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

    }
}
