using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class LivroEducativo : Livro
    {
        private int anoEscolaridade;

        public int AnoEscolaridade
        {
            get { return anoEscolaridade; }
            set { anoEscolaridade = value; }
        }

        public LivroEducativo(string titulo, string autor, string isbn, int anoPublicacao, int anoEscolaridade)
            : base(titulo, autor, isbn, anoPublicacao)
        {
            this.anoEscolaridade = anoEscolaridade;
        }
    }
}
