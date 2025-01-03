using gestaobiblioteca;
using gestaobilbliotecaFINAL;

using static gestaobiblioteca.Clientes;

namespace gestaobiblioteca
{
    public class Program
    {    
        //titulo, autor, isbn, ano de publica��o
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            LivroCientifico livroCientifico = new LivroCientifico("O Universo em Uma Casca de Noz", "Stephen Hawking", "654321", 2002, "Espa�o");
            livroCientifico.ExibirInfo();

            LivroEducativo livroEducativo = new LivroEducativo("Ci�ncias Naturais", "Maria Silva", "7891011", 2015, 11);
            livroEducativo.ExibirInfo();


            //Clientes
            double valorBaseMulta = 100.0;

            Clientes leitorComum = new LeitorComum(001, "Carlos Silva", 30, 3);
            Clientes estudante = new Estudante(002, "Maria Oliveira", 20, 5, "Universidade XYZ");
            Clientes professor = new Professor(003, "Jo�o Almeida", 45, 8, "Matem�tica");
            Clientes senior = new Senior(004, "Ana Costa", 65, 4, 15);

            leitorComum.ExibirInfo();
            Console.WriteLine();

            estudante.ExibirInfo();
            Console.WriteLine();

            professor.ExibirInfo();
            Console.WriteLine();

            senior.ExibirInfo();
            Console.WriteLine();



            //Livros do empr�stimo
            var LivroCientifico = new LivroCientifico("F�sica Avan�ada", "Isaac Newton", "123-456", 2005, "F�sica");
            var LivroEducativo = new LivroEducativo("Biologia B�sica", "Darwin", "789-101", 2010, 12);
            var LivroFiccao = new LivroFiccao("Viagem ao Espa�o", "H.G. Wells", "111-222", 1895, "Alien�genas");
            var jornal = new Jornal("Di�rio Not�cias", "Editora X", "333-444", 2023, "Di�rio");

            var emprestimo1 = new Emprestimo(professor, livroCientifico, DateTime.Now);
            var emprestimo2 = new Emprestimo(estudante, livroEducativo, DateTime.Now);
            var emprestimo3 = new Emprestimo(senior, jornal, DateTime.Now);
            var emprestimo4 = new Emprestimo(leitorComum, LivroFiccao, DateTime.Now);

            //Emprestimo multas
            emprestimo1.ProcessarDevolucao();
            emprestimo2.ProcessarDevolucao();
            emprestimo3.ProcessarDevolucao();
            emprestimo4.ProcessarDevolucao();

            // Criando o sistema de reservas
            SistemaReservas sistemaReservas = new SistemaReservas();

            // Fazendo reservas
            sistemaReservas.AdicionarReserva(estudante, LivroEducativo);
            sistemaReservas.AdicionarReserva(leitorComum, LivroFiccao);
            sistemaReservas.AdicionarReserva(professor, LivroCientifico);

            // Exibindo as reservas
            sistemaReservas.ExibirReservas();

            Console.ReadLine();

            //emprestimo historico (Classe emprestimo)
        }

     

    }
}




