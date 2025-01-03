using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Revista : Livro
    {

        public int NumEdicao { get; set; }
        public Revista(string titulo, string autor, string isbn, int anoPublicacao, int numEdicao)
            : base(titulo, autor, isbn, anoPublicacao)
        {
            NumEdicao = numEdicao;
        }
        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Número de Edição: {NumEdicao}");
        }
    }
}