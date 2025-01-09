using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Leitor
    {
        public static List<Leitor> clientes = new List<Leitor>();
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int LivrosRequisitados { get; set; }
        public int LimiteLivros { get; set; }
        public double DescontoMulta { get; set; }
        public double ValorBaseMulta { get; set; }
        public int LimiteReservas { get; set; }
        public double Prioridade { get; set; }

        public Leitor(int Id, string nome, int idade, int livrosRequisitados, int limitelivros, double descontomulta, double valorbasemulta, int limitereservas, double prioridade)
        {
            ID = Id;
            Nome = nome;
            Idade = idade;
            LivrosRequisitados = livrosRequisitados;
            LimiteLivros = limitelivros;
            DescontoMulta = descontomulta;
            ValorBaseMulta = valorbasemulta;
            LimiteReservas = limitereservas;
            Prioridade = prioridade;
        }

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Livros Requisitados: {LivrosRequisitados}, Limite de Livros: {LimiteLivros}, Desconto em multa: {DescontoMulta * 100}%, Limite de Reservas: {LimiteReservas}, Prioridade: {Prioridade}");
        }

        public virtual int CalcularPrazoDevolucao(Livro livro)
        {
            return 15; // Prazo padrão
        }

        public virtual double CalcularMulta(int diasEmAtraso)
        {
            return diasEmAtraso * ValorBaseMulta; // Multa padrão
        }

        public virtual bool PodeProrrogarEmprestimo()
        {
            return false;
        }

        public virtual void EnviarNotificacaoAtraso(Emprestimo emprestimo)
        {
            Console.WriteLine($"Leitor {Nome}, você tem um empréstimo atrasado. Por favor, devolva o livro {emprestimo.LivroEmprestado.Titulo}."); // Este texto deverá ser passado para E-mail ou SMS. Serve apenas como exemplo, não é implementado.
        }
    }
}
