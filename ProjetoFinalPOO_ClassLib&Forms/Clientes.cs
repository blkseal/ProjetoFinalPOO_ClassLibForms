using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Clientes
    {
        public static List<Clientes> clientes = new List<Clientes>();
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int LivrosRequisitados { get; set; }
        public int LimiteLivros { get; set; }
        public double DescontoMulta { get; set; }
        public double ValorBaseMulta { get; set; }

        public int LimiteReservas { get; set; }
        public double Prioridade { get; set; }

        public Clientes(int Id, string nome, int idade, int livrosRequisitados, int limitelivros, double descontomulta, double valorbasemulta, int limitereservas, double prioridade)
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

          /*  if (LivrosRequisitados > LimiteLivros) 
                throw new ArgumentException("O número de livros requisitados excede o limite permitido."); */

        }
        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Livros Requisitados: {LivrosRequisitados}, Limite de Livros: {LimiteLivros}, Desconto em multa: {DescontoMulta * 100}%, Limite de Reservas: {LimiteReservas}, Prioridade: {Prioridade}");
        }

        //os valores de livro limite e multa são os valores predefinidos para leitor comum
        public virtual int ObterLimiteLivros() //virtual funciona como um override
        {
            return 5;
        }

        //multa
        public virtual double CalcularMulta(double valorBase)
        {
            double desconto = valorBase * DescontoMulta;
            double valorFinal = valorBase - desconto;
            Console.WriteLine($"Valor base da multa: {valorBase} EUR");
            Console.WriteLine($"Desconto aplicado: {desconto:F2} EUR ({DescontoMulta * 100}%)");
            Console.WriteLine($"Valor final da multa: {valorFinal:F2} EUR");
            return valorFinal;
        }
    }
}
