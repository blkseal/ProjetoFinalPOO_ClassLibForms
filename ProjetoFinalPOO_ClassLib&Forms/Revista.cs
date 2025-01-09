using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Revista : Livro
    {
        private int numEdicao;

        public int NumEdicao // Número da edição da revista
        {
            get { return numEdicao; }
            set { numEdicao = value; }
        }

        public Revista(string titulo, string autor, string isbn, int anoPublicacao, int numEdicao)
            : base(titulo, autor, isbn, anoPublicacao)
        {
            this.numEdicao = numEdicao;
        }
    }
}
