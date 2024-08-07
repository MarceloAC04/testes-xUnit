using api_teste.Context;
using api_teste.Domains;
using api_teste.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api_teste.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ProductContext _productContext;

        public ProductsRepository()
        {
            _productContext = new ProductContext();
        }

         public List<Products> Listar()
         {
            try
            {
                return _productContext.Products.ToList();

            }
            catch (Exception)
            {

                throw;
            }
         }

        public Products BuscarPorId(Guid id)
        {
            try
            {
                return _productContext.Products.Find(id)!;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Products novoProduto)
        {
            try
            {
                _productContext.Add(novoProduto);

                _productContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Atualizar(Guid id, Products novoProduto)
        {
            try
            {
               Products produtoBuscado = _productContext.Products.Find(id)!;

                if (produtoBuscado != null)
                {
                    produtoBuscado.Name = novoProduto.Name;
                    produtoBuscado.Price = novoProduto.Price;  
                }

                _productContext.Products.Update(produtoBuscado!);

                _productContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Products produtoBuscado = _productContext.Products.Find(id)!;

                _productContext.Products.Remove(produtoBuscado);

                _productContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
