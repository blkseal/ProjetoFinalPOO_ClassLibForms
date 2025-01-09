using gestaobiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms
{
    internal class Gestor
    {

        public void CreateNewBook(string titulo, string autor, string isbn, int anoPublicacao, string tipo, string dependsOnType)
        {


            Livro novoLivro;

            switch (tipo)
            {
                case "Cientifico":
                    string area = dependsOnType;
                    novoLivro = new LivroCientifico(titulo, autor, isbn, anoPublicacao, area);
                    break;
                case "Educativo":
                    int anoEscolaridade = Convert.ToInt32(dependsOnType);
                    novoLivro = new LivroEducativo(titulo, autor, isbn, anoPublicacao, anoEscolaridade);
                    break;
                case "Ficção":
                    string categoria = dependsOnType;
                    novoLivro = new LivroFiccao(titulo, autor, isbn, anoPublicacao, categoria);
                    break;
                case "Revista":
                    int numEdicao = Convert.ToInt32(dependsOnType);
                    novoLivro = new Revista(titulo, autor, isbn, anoPublicacao, numEdicao);
                    break;
                case "Jornal":
                    string anoEdicao = dependsOnType;
                    novoLivro = new Jornal(titulo, autor, isbn, anoPublicacao, anoEdicao);
                    break;
                default:
                    throw new ArgumentException("Tipo de livro desconhecido.");
            }
            Livro.Livros.Add(novoLivro);
            MessageBox.Show("Livro guardado com sucesso!");
        }


        public void SalvarLivroTxt(string caminhoArquivo)
        {
            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                foreach (var livro in Livro.Livros)
                {
                    if (livro is LivroCientifico livroCientifico)
                    {
                        writer.WriteLine($"{livro.Titulo};{livro.Autor};{livro.ISBN};{livro.Ano};{livro.Disponivel};{livroCientifico.Area};2");
                    }
                    else if (livro is LivroEducativo livroEducativo)
                    {
                        writer.WriteLine($"{livro.Titulo};{livro.Autor};{livro.ISBN};{livro.Ano};{livro.Disponivel};{livroEducativo.AnoEscolaridade};1");
                    }
                    else if (livro is LivroFiccao livroFiccao)
                    {
                        writer.WriteLine($"{livro.Titulo};{livro.Autor};{livro.ISBN};{livro.Ano};{livro.Disponivel};{livroFiccao.Categoria};3");
                    }
                    else if (livro is Revista revista)
                    {
                        writer.WriteLine($"{livro.Titulo};{livro.Autor};{livro.ISBN};{livro.Ano};{livro.Disponivel};{revista.NumEdicao};4");
                    }
                    else if (livro is Jornal jornal)
                    {
                        writer.WriteLine($"{livro.Titulo};{livro.Autor};{livro.ISBN};{livro.Ano};{livro.Disponivel};{jornal.Dia};5");
                    }
                    else
                    {
                        // MessageBox.Show($"Tipo de livro desconhecido no Livro ({livro.Titulo})", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        public void LerLivroTxt(string caminhoArquivo)
        {
            if (File.Exists(caminhoArquivo))
            {
                Livro.Livros.Clear();

                using (StreamReader reader = new StreamReader(caminhoArquivo))
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        try
                        {
                            var dados = linha.Split(';');
                            if (dados.Length != 7)
                            {
                                throw new FormatException("Linha com formato incorreto.");
                            }

                            string titulo = dados[0];
                            string autor = dados[1];
                            string isbn = dados[2];
                            int ano = int.Parse(dados[3]);
                            bool disponivel = bool.Parse(dados[4]);
                            string tipoEspecifico = dados[5];
                            int tipoLivro = int.Parse(dados[6]);

                            Livro novoLivro = tipoLivro switch
                            {
                                1 => new LivroEducativo(titulo, autor, isbn, ano, int.Parse(tipoEspecifico)),
                                2 => new LivroCientifico(titulo, autor, isbn, ano, tipoEspecifico),
                                3 => new LivroFiccao(titulo, autor, isbn, ano, tipoEspecifico),
                                4 => new Revista(titulo, autor, isbn, ano, int.Parse(tipoEspecifico)),
                                5 => new Jornal(titulo, autor, isbn, ano, tipoEspecifico),
                                _ => throw new ArgumentException("Tipo de livro desconhecido.")
                            };

                            novoLivro.Disponivel = disponivel;
                            Livro.Livros.Add(novoLivro);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao ler linha: {linha}\nErro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void CreateNewCliente(int id, string nome, int idade, int livrosRequisitados, string tipo, string dependsOnType)
        {
            Clientes novoCliente = tipo switch
            {
                "Comum" => new LeitorComum(id, nome, idade, livrosRequisitados, Convert.ToInt32(dependsOnType)),
                "Senior" => new Senior(id, nome, idade, livrosRequisitados, Convert.ToInt32(dependsOnType)),
                "Estudante" => new Estudante(id, nome, idade, livrosRequisitados, dependsOnType),
                "Professor" => new Professor(id, nome, idade, livrosRequisitados, dependsOnType),
                _ => throw new ArgumentException("Tipo de cliente desconhecido.")
            };

            Clientes.clientes.Add(novoCliente);
            MessageBox.Show("Cliente criado com sucesso!");
        }

        public void SalvarClienteTxt(string caminhoArquivo)
        {
            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                foreach (var cliente in Clientes.clientes)
                {
                    if (cliente is Senior senior)
                    {
                        writer.WriteLine($"{cliente.ID};{cliente.Nome};{cliente.Idade};{cliente.LivrosRequisitados};{senior.AnosRegistro};1");
                    }
                    else if (cliente is Estudante estudante)
                    {
                        writer.WriteLine($"{cliente.ID};{cliente.Nome};{cliente.Idade};{cliente.LivrosRequisitados};{estudante.Instituicao};2");
                    }
                    else if (cliente is Professor professor)
                    {
                        writer.WriteLine($"{cliente.ID};{cliente.Nome};{cliente.Idade};{cliente.LivrosRequisitados};{professor.Disciplina};3");
                    }
                    else if (cliente is LeitorComum leitorComum)
                    {
                        writer.WriteLine($"{cliente.ID};{cliente.Nome};{cliente.Idade};{cliente.LivrosRequisitados};{leitorComum.nrCartao};4");
                    }
                }
            }
        }

        public void LerClienteTxt(string caminhoArquivo)
        {
            if (File.Exists(caminhoArquivo))
            {
                Clientes.clientes.Clear();

                using (StreamReader reader = new StreamReader(caminhoArquivo))
                {
                    string linha;
                    while ((linha = reader.ReadLine()) != null)
                    {
                        try
                        {
                            var dados = linha.Split(';');
                            if (dados.Length != 6)
                            {
                                throw new FormatException("Linha com formato incorreto.");
                            }

                            int id = int.Parse(dados[0]);
                            string nome = dados[1];
                            int idade = int.Parse(dados[2]);
                            int livrosRequisitados = int.Parse(dados[3]);
                            string tipoEspecifico = dados[4];
                            int tipoCliente = int.Parse(dados[5]);

                            Clientes novoCliente = tipoCliente switch
                            {
                                1 => new Senior(id, nome, idade, livrosRequisitados, int.Parse(tipoEspecifico)),
                                2 => new Estudante(id, nome, idade, livrosRequisitados, tipoEspecifico),
                                3 => new Professor(id, nome, idade, livrosRequisitados, tipoEspecifico),
                                4 => new LeitorComum(id, nome, idade, livrosRequisitados, int.Parse(tipoEspecifico)),
                                _ => throw new ArgumentException("Tipo de cliente desconhecido.")
                            };

                            Clientes.clientes.Add(novoCliente);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao ler linha: {linha}\nErro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Arquivo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<Reserva> Reservas = new List<Reserva>();

        public void ReservarLivro(string livroID, int clienteID)
        {
            var cliente = Clientes.clientes.FirstOrDefault(c => c.ID == clienteID);
            if (cliente == null)
            {
                throw new ArgumentException("Cliente não encontrado.");
            }

            string livroIDStr = livroID.ToString().Trim();

            var livro = Livro.Livros.FirstOrDefault(l => l.ISBN.Trim() == livroIDStr);
            if (livro == null)
            {
                throw new ArgumentException("Livro não encontrado.");
            }

            if (livro.Disponivel)
            {
                MessageBox.Show("O livro está disponível e não pode ser reservado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Reservas.Count(r => r.ClienteID == clienteID) >= cliente.LimiteReservas)
            {
                MessageBox.Show("Limite de reservas atingido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int reservaID = Reservas.Count + 1;
            DateTime dataReserva = DateTime.Now;
            int prioridade = (int)cliente.Prioridade;

            Reserva novaReserva = new Reserva(reservaID, livroID, clienteID, dataReserva, prioridade);
            Reservas.Add(novaReserva);
            MessageBox.Show("Reserva criada com sucesso!");
        }

        public List<Reserva> ObterReservasPorLivro(string livroID)
        {
            return Reservas.Where(r => r.LivroID == livroID).OrderBy(r => r.Prioridade).ThenBy(r => r.DataReserva).ToList();
        }

        public void NotificarProximoLeitor(string livroID)
        {
            var reservas = ObterReservasPorLivro(livroID);
            if (reservas.Count > 0)
            {
                var proximaReserva = reservas.First();
                var cliente = Clientes.clientes.FirstOrDefault(c => c.ID == proximaReserva.ClienteID);
                if (cliente != null)
                {
                    MessageBox.Show($"O livro está disponível para o cliente {cliente.Nome}.", "Notificação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reservas.Remove(proximaReserva);
                }
            }
        }

        public void MarcarLivroComoDisponivel(string livroID) // Aplicar nas devoluções
        {
            var livro = Livro.Livros.FirstOrDefault(l => l.ISBN == livroID.ToString());
            if (livro != null)
            {
                livro.Disponivel = true;
                NotificarProximoLeitor(livroID);
            }
        }

    }
}

