using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Jornal : Livro
    {
        public string Dia { get; set; }
        public Jornal(string titulo, string autor, string isbn, int anoPublicacao, string dia)
            : base(titulo, autor, isbn, anoPublicacao)
        {
            Dia = dia; //dd/mm/aaaa
        }
        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Dia da edição: {Dia}");
        }
    }
}