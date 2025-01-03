using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class LivroEducativo : Livro
    {

        public int AnoEscolaridade { get; set; }

        public LivroEducativo(string titulo, string autor, string isbn, int anoPublicacao, int anoEscolaridade)
            : base(titulo, autor, isbn, anoPublicacao)
        {
            AnoEscolaridade = anoEscolaridade;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Ano de Escolaridade: {AnoEscolaridade}");
        }
    }
}
