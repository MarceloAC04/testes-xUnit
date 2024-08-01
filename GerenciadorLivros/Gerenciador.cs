using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorLivros
{
    public static class Gerenciador
    {
        public static List<Livro>? colecao { get; set; }

        public static List<Livro> Adicionar(Livro novoLivro)
        { 
            colecao?.Add(novoLivro);

            return colecao!;
        }
    }
}
