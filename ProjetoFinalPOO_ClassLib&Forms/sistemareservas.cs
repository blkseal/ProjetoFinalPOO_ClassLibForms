using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class SistemaReservas
    {
        private List<Reservas> reservas = new List<Reservas>();

        public void AdicionarReserva(Clientes cliente, Livro livro)
        {
            if (!livro.Disponivel)
            {
                if (reservas.Count(r => r.Livro == livro) >= cliente.LimiteReservas)
                {
                    Console.WriteLine($"Cliente {cliente.Nome} atingiu o limite de reservas.");
                    return;
                }

                reservas.Add(new Reservas(cliente, livro));
                Console.WriteLine($"Reserva adicionada para {cliente.Nome} no livro: {livro.Titulo}");
                AtualizarPrioridades();
            }
            else
            {
                Console.WriteLine($"O livro {livro.Titulo} está disponível. Não é necessária uma reserva.");
            }
        }

        private void AtualizarPrioridades()
        {
            reservas = reservas.OrderByDescending(r => r.Cliente.Prioridade).ToList();
        }

        public void ExibirReservas()
        {
            Console.WriteLine("\n--- Lista de Reservas ---");
            foreach (var reserva in reservas)
            {
                reserva.ExibirReservaInfo();
            }
        }
    }
}