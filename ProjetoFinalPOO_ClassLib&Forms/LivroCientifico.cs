using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class LivroCientifico : Livro
    {
        private string area; // Area de conhecimento

        public string Area 
        {
            get { return area; } 
            set { area = value; }
        }

        public LivroCientifico(string titulo, string autor, string isbn, int anoPublicacao, string area)
            : base(titulo, autor, isbn, anoPublicacao)
        {
            this.area = area;
        }
    }
}
