using api_teste.Domains;

namespace api_teste.Interfaces
{
    public interface IProductsRepository
    {
       public List<Products> Listar();

       public Products BuscarPorId(Guid id);

       public void Cadastrar(Products novoProduto);

       public void Atualizar(Guid id, Products novoProduto);

       public void Deletar(Guid id);
    }
}
