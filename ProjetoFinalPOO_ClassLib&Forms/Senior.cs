using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Senior : Leitor
    {
        public int AnosRegistro { get; set; }
        public Senior(int Id, string nome, int idade, int livrosrequesitados, int anosregistro)
            : base(Id, nome, idade, livrosrequesitados, limitelivros: 7, descontomulta: 0.3, valorbasemulta: 1, limitereservas: 2, prioridade: 1.5)
        {
            AnosRegistro = anosregistro;
        }
        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($"Tipo de leitor: Senior, Anos de Registro: {AnosRegistro}");
        }

        public override int CalcularPrazoDevolucao(Livro livro)
        {
            return 28; // Prazo estendido para todos os tipos de livros
        }

        public override double CalcularMulta(int diasEmAtraso)
        {
            return diasEmAtraso * ValorBaseMulta * (1 - DescontoMulta); // Com desconto
        }
    }
}
