using GerenciadorLivros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivro.Test
{
    public class GerenciadorTest
    {
        [Fact]
        public void TestarGerenciador()
        {
            Livro livro = new Livro();
            livro.nome = "O Hobbit";
            livro.genero = "Fantasia";
            livro.autor = "J.R.R Tolkien";;

            Gerenciador.Adicionar(livro);
            var resultado = Gerenciador.Adicionados();

            Assert.Contains(livro, resultado);
        }
    }
}
