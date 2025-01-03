using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Senior : Clientes
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
    }
}