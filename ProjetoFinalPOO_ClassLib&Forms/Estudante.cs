using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Estudante : Leitor
    {
        public string Instituicao { get; set; }
        public Estudante(int Id, string nome, int idade, int livrosrequesitados, string instituicao)
            : base(Id, nome, idade, livrosrequesitados, limitelivros: 5, descontomulta: 0.5, valorbasemulta: 1.5, limitereservas: 8, prioridade: 2.0)
        {
            Instituicao = instituicao;
        }
        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Tipo de leitor: Estudante, Instituição: {Instituicao}");
        }

        public override int CalcularPrazoDevolucao(Livro livro)
        {
            if (livro is LivroEducativo)
            {
                return 25; // Mais tempo para livros educativos
            }
            return 15; // Prazo normal para outros tipos de livros
        }

        public override double CalcularMulta(int diasEmAtraso)
        {
            return diasEmAtraso * ValorBaseMulta * (1 - DescontoMulta); // Com desconto
        }

        public override bool PodeProrrogarEmprestimo()
        {
            return true;
        }

        public override void EnviarNotificacaoAtraso(Emprestimo emprestimo)
        {
            Console.WriteLine($"Estudante {Nome}, você tem um empréstimo atrasado. Por favor, devolva o livro {emprestimo.LivroEmprestado.Titulo}. Lembre-se de que você pode prorrogar o empréstimo.");
        }
    }
}
