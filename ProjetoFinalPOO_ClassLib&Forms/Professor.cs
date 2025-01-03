using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Professor : Clientes
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
    }
}
