using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleInventario
{
    public static class Inventario
    {
        public static List<Produto> produtos = new List<Produto>();

        public static void AdicionarProduto(Produto produto)
        {
            if (!produtos.Contains(produto))
            {
                produtos.Add(produto);
            }

            var index = produtos.IndexOf(produto);
            produtos[index].quantidade++;
        }

        public static int QuantidadeProduto(Produto produto)
        {
            var i = produtos.IndexOf(produto);
            return produtos[i].quantidade;
        }

        public static List<Produto> ProdutosAdicionados()
        {
            return new List<Produto>(produtos!);
        }

        public static int QuantidadeProdutoNome(string nome)
        {
            int produtoIndex = produtos.FindIndex(x => x.nome == nome);
            return produtos[produtoIndex].quantidade;
        }
    }
}
