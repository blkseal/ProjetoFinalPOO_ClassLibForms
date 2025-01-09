using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Professor : Leitor
    {
        public string Disciplina { get; set; }
        public Professor(int Id, string nome, int idade, int livrosrequesitados, string disciplina)
            : base(Id, nome, idade, livrosrequesitados, limitelivros: 10, descontomulta: 0.8, valorbasemulta: 2.0, limitereservas: 5, prioridade: 1.0)
        {
            Disciplina = disciplina;
        }
        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Tipo de Cliente: Professor, Disciplina: {Disciplina}");
        }

        public override int CalcularPrazoDevolucao(Livro livro)
        {
            if (livro is LivroCientifico)
            {
                return 30; // Mais tempo para livros científicos
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
            Console.WriteLine($"Professor {Nome}, você tem um empréstimo atrasado. Por favor, devolva o livro {emprestimo.LivroEmprestado.Titulo}. Lembre-se das vantagens de prorrogação.");
        }
    }
}
