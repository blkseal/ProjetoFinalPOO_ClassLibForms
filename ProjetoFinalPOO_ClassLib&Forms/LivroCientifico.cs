using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class LivroCientifico : Livro
    {
        public string Area { get; set; }

        public LivroCientifico(string titulo, string autor, string isbn, int anoPublicacao, string area)
            : base(titulo, autor, isbn, anoPublicacao)
        {
            Area = area;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Área: {Area}");
        }
    }
}