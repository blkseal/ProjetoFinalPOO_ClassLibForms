using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Emprestimo
    {
        public Clientes Cliente { get; set; }
        public Livro LivroEmprestado { get; set; }
        public DateTime DataEmprestimo { get; set; } //DateTime é usado para calcular informações dos dias hora 
        public DateTime DataDevolucao { get; private set; }

        public Emprestimo(Clientes cliente, Livro livro, DateTime dataEmprestimo)
        {
            Cliente = cliente;
            LivroEmprestado = livro;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = CalcularDataDevolucao();
        }
        public void ExibirEmprestimo()
        {
            Console.WriteLine("---Informações do Empréstimo---");
            LivroEmprestado.ExibirInfo();
            Cliente.ExibirInfo();
            Console.WriteLine($"Data do Empréstimo: {DataEmprestimo:dd / MM / yyyy}");
            Console.WriteLine($"Data de Devolução: {DataDevolucao:dd/MM/yyyy}");
        }
        //calcula os dias de emprestimo para cada tipo de cliente
        private DateTime CalcularDataDevolucao()
        {
            int diasemprestimo = 15;

            if (Cliente is Professor && LivroEmprestado is LivroCientifico)
            {
                diasemprestimo = 30;
            }
            else if (Cliente is Estudante && LivroEmprestado is LivroEducativo)
            {
                diasemprestimo = 25;
            }
            else if (Cliente is Senior)
            {
                diasemprestimo = 28;
            }
            return DataEmprestimo.AddDays(diasemprestimo);
        }

        //processa a devolucao e mostra o valor da multa
        public void ProcessarDevolucao()
        {
            Console.WriteLine("---Processar Devolução---");
            ExibirEmprestimo();
            int diasEmAtraso = (DataDevolucao - CalcularDataDevolucao()).Days;
            double valorMulta = 0;

            if (diasEmAtraso > 0)
            {
                valorMulta = diasEmAtraso * Cliente.ValorBaseMulta * Cliente.DescontoMulta;
            }

            if (valorMulta > 0)
            {
                Console.WriteLine($"Multa total: {valorMulta:F2} EUR");
            }

            else
            {
                Console.WriteLine("Nenhuma multa foi aplicada");
            }
        }

        //HISTORICO EMPRESTIMO
        public List<Emprestimo> HistoricoEmprestimos { get; set; } = new List<Emprestimo>();

        public void AdicionarAoHistorico(Emprestimo emprestimo)
        {
            HistoricoEmprestimos.Add(emprestimo);
        }
        public void ExibirHistorico()
        {
            Console.WriteLine($"--- Histórico de Empréstimos de {Cliente} ---");
            if (HistoricoEmprestimos.Count == 0)
            {
                Console.WriteLine("Nenhum empréstimo registrado.");
            }
            else
            {
                foreach (var emprestimo in HistoricoEmprestimos)
                {
                    emprestimo.ExibirEmprestimo();
                }
            }
        }
    }
}
