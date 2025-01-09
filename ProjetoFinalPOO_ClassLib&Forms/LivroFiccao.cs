using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class LivroFiccao : Livro
    {
        private string categoria;

        public string Categoria // Categoria do livro de ficção
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public LivroFiccao(string titulo, string autor, string isbn, int anoPublicacao, string categoria)
            : base(titulo, autor, isbn, anoPublicacao)
        {
            this.categoria = categoria;
        }
    }
}
