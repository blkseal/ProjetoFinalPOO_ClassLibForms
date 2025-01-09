using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace gestaobiblioteca
{
    public class Reserva
    {
        public int ReservaID { get; set; }
        public string LivroID { get; set; }
        public int ClienteID { get; set; }
        public DateTime DataReserva { get; set; }
        public double Prioridade { get; set; }

        public Reserva(int reservaID, string livroID, int clienteID, DateTime dataReserva, double prioridade)
        {
            ReservaID = reservaID;
            LivroID = livroID;
            ClienteID = clienteID;
            DataReserva = dataReserva;
            Prioridade = prioridade;
        }
    }
}
