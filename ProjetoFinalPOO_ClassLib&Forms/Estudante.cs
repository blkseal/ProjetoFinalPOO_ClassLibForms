using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Estudante : Clientes
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
    }
}
