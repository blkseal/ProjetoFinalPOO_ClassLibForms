using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace gestaobiblioteca
{
    public abstract class Livro
    {
        public static List<Livro> Livros = new List<Livro>();
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public string ISBN { get; set; }
        public bool Disponivel { get; set; }
        public Livro(string titulo, string autor, string isbn, int anoPublicacao)
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Ano = anoPublicacao;
            Disponivel = true;
        }

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Ano: {Ano},Disponível: {Disponivel}");
        }
    }
}