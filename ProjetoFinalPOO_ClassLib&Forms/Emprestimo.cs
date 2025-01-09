using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace gestaobiblioteca
{
    public class Emprestimo
    {
        public static List<Emprestimo> Emprestimos = new List<Emprestimo>();

        public Leitor Cliente { get; set; }
        public Livro LivroEmprestado { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; private set; }
        public double Multa { get; private set; }

        public Emprestimo(Leitor cliente, Livro livro, DateTime dataEmprestimo)
        {
            Cliente = cliente;
            LivroEmprestado = livro;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = CalcularDataDevolucao();
            Multa = 0;
        }

        public Emprestimo(Leitor cliente, Livro livro, DateTime dataEmprestimo, DateTime dataDevolucao, double multa)
        {
            Cliente = cliente;
            LivroEmprestado = livro;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
            Multa = multa;
        }

        private DateTime CalcularDataDevolucao()
        {
            int diasEmprestimo = Cliente.CalcularPrazoDevolucao(LivroEmprestado);
            return DataEmprestimo.AddDays(diasEmprestimo);
        }

        public void ProcessarDevolucao()
        {
            int diasEmAtraso = (DateTime.Now - DataDevolucao).Days;
            if (diasEmAtraso > 0)
            {
                Multa = Cliente.CalcularMulta(diasEmAtraso);
            }
            else
            {
                Multa = 0;
            }
        }

        public bool ProrrogarEmprestimo(int dias)
        {
            if (Cliente.PodeProrrogarEmprestimo())
            {
                DataDevolucao = DataDevolucao.AddDays(dias);
                return true;
            }
            return false;
        }

        public List<Emprestimo> HistoricoEmprestimos { get; set; } = new List<Emprestimo>();

        public void AdicionarAoHistorico(Emprestimo emprestimo)
        {
            HistoricoEmprestimos.Add(emprestimo);
        }

        public static void EnviarNotificacoesAtraso()
        {
            foreach (var emprestimo in Emprestimos)
            {
                if (emprestimo.DataDevolucao < DateTime.Now && emprestimo.Multa > 0)
                {
                    emprestimo.Cliente.EnviarNotificacaoAtraso(emprestimo);
                }
            }
        }
    }
}