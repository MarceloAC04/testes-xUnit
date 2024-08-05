using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInventario.Test
{
    public class ControleInventarioTeste
    {
        [Fact]
        public void AdicionarProdutoTeste()
        {
            Produto produtoTeste = new Produto();
            produtoTeste.nome = "Playstation 7";
            produtoTeste.quantidade = 1;

            Inventario.AdicionarProduto(produtoTeste);
            var resultado = Inventario.ProdutosAdicionados();

            Assert.Contains(produtoTeste, resultado);
        }

        [Fact]
        public void VerificarQuantidadeTeste()
        {
            Produto produtoTeste = new Produto();
            produtoTeste.nome = "Playstation 7";

            Inventario.AdicionarProduto(produtoTeste);
            Inventario.AdicionarProduto(produtoTeste);
            Inventario.AdicionarProduto(produtoTeste);

            var resultado = Inventario.QuantidadeProduto(produtoTeste);

            var valorEsperado = 3;

            Assert.Equal(resultado, valorEsperado);

        }

        [Fact]
        public void VerificarQuantidadePorNomeTeste()
        {
            Produto produtoTeste = new Produto();
            produtoTeste.nome = "Xbox 720";
            Inventario.AdicionarProduto(produtoTeste);
            Inventario.AdicionarProduto(produtoTeste);


            var resultado = Inventario.QuantidadeProdutoNome(produtoTeste.nome);

            var esperado = 2;

            Assert.Equal(resultado, esperado);
        }
    }
}
