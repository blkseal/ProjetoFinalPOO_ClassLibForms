using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Jornal : Livro
    {
        private string dia; // Data de publicação (dd/mm/aaaa) 

        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }

        public Jornal(string titulo, string autor, string isbn, int anoPublicacao, string dia)
            : base(titulo, autor, isbn, anoPublicacao)
        {
            this.dia = dia; //dd/mm/aaaa
        }
    }
}
