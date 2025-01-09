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

        public static List<Livro> Livros = new List<Livro>(); // Lista de livros 

        // Encapsulamento das variáveis
        private string titulo;
        private string autor;
        private int ano;
        private string isbn;
        private bool disponivel;

        public string Titulo
        {
            get { return titulo; } // Retornar o valor de uma variável privada
            set { titulo = value; } // Alterar o valor de uma variável privada
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public bool Disponivel
        {
            get { return disponivel; }
            set { disponivel = value; }
        }

        public Livro(string titulo, string autor, string isbn, int anoPublicacao) // Construtor
        {
            this.titulo = titulo;
            this.autor = autor;
            this.isbn = isbn;
            this.ano = anoPublicacao;
            this.disponivel = true;
        }
    }
}