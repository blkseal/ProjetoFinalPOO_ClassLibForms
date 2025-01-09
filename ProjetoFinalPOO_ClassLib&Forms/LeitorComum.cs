using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class LeitorComum : Clientes
    {
        public int nrCartao { get; set; }
        public LeitorComum(int Id, string nome, int idade, int livrosrequesitados, int NrCartao)
            : base(Id, nome, idade, livrosrequesitados, limitelivros: 5, descontomulta: 0.0, valorbasemulta: 3, limitereservas: 2, prioridade: 0.5)
        {
            nrCartao = NrCartao;
        }
        public override void ExibirInfo()
        {
            base.ExibirInfo(); //exibe as informações base como nome, idade, livrosrequesitados
            Console.WriteLine($"Tipo de Cliente:Leitor Comum, Nr de Cartão: {nrCartao}");

        }
    }
}
