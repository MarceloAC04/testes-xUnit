using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros
{
    public static class Gerenciador
    {
        public static List<Livro>? colecao = new List<Livro>();

        public static void Adicionar(Livro novoLivro)
        { 
            colecao?.Add(novoLivro);

        }

        public static List<Livro> Adicionados()
        {
            return new List<Livro>(colecao!); 
        }
    }
}
