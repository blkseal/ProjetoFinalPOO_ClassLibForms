using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Reservas
    {
        public Clientes Cliente { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataReserva { get; set; }

        public Reservas(Clientes cliente, Livro livro)
        {
            Cliente = cliente;
            Livro = livro;
            DataReserva = DateTime.Now;
        }

        public void ExibirReservaInfo()
        {
            Console.WriteLine($"Reserva feita por: {Cliente.Nome}, Prioridade: {Cliente.Prioridade}");
            Console.WriteLine($"Livro reservado: {Livro.Titulo}");
            Console.WriteLine($"Data da reserva: {DataReserva:dd/MM/yyyy HH:mm}");
        }
    }
}
