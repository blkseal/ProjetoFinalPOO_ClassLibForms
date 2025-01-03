using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class LivroFiccao : Livro
    {
        public string Categoria { get; set; }

        public LivroFiccao(string titulo, string autor, string isbn, int anoPublicacao, string categoria)
            : base(titulo, autor, isbn, anoPublicacao)
        {
            Categoria = categoria;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Gênero: {Categoria}");
        }
    }
}