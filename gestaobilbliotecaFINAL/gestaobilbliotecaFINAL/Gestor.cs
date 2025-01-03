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
            MessageBox.Show("Livro criado com sucesso!");
        }


        public void SalvarLivroTxt(string caminhoArquivo)
        {
            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                foreach (var livro in Livro.Livros)
                {
                    if (livro is LivroCientifico livroCientifico)
                    {
                        writer.WriteLine($"{livro.Titulo};{livro.Autor};{livro.ISBN};{livro.Ano};{livro.Disponivel};{livroCientifico.Area}");
                    }
                    else if (livro is LivroEducativo livroEducativo)
                    {
                        writer.WriteLine($"{livro.Titulo};{livro.Autor};{livro.ISBN};{livro.Ano};{livro.Disponivel};{livroEducativo.AnoEscolaridade}");
                    }
                    else if (livro is LivroFiccao livroFiccao)
                    {
                        writer.WriteLine($"{livro.Titulo};{livro.Autor};{livro.ISBN};{livro.Ano};{livro.Disponivel};{livroFiccao.Categoria}");
                    }
                    else if (livro is Revista revista)
                    {
                        writer.WriteLine($"{livro.Titulo};{livro.Autor};{livro.ISBN};{livro.Ano};{livro.Disponivel};{revista.NumEdicao}");
                    }
                    else if (livro is Jornal jornal)
                    {
                        writer.WriteLine($"{livro.Titulo};{livro.Autor};{livro.ISBN};{livro.Ano};{livro.Disponivel};{jornal.Dia}");
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
                
                    var dados = linha.Split(';');
                    string titulo = dados[0];
                    string autor = dados[1];
                    string isbn = dados[2];
                    int ano = int.Parse(dados[3]);
                    bool disponivel = bool.Parse(dados[4]);

                    if (dados.Length == 6)
                    {
                        string tipoEspecifico = dados[5];

                        if (tipoEspecifico.Contains("Área"))
                        {
                            Livro.Livros.Add(new LivroCientifico(titulo, autor, isbn, ano, tipoEspecifico));
                        }
                        else if (int.TryParse(tipoEspecifico, out int anoEscolaridade))
                        {
                            Livro.Livros.Add(new LivroEducativo(titulo, autor, isbn, ano, anoEscolaridade));
                        }
                        else if (tipoEspecifico.Contains("Gênero"))
                        {
                            Livro.Livros.Add(new LivroFiccao(titulo, autor, isbn, ano, tipoEspecifico));
                        }
                        else if (tipoEspecifico.Contains("Número de Edição"))
                        {
                            Livro.Livros.Add(new Revista(titulo, autor, isbn, ano, int.Parse(tipoEspecifico)));
                        }
                        else if (tipoEspecifico.Contains("Dia de Edição"))
                        {
                            Livro.Livros.Add(new Jornal(titulo, autor, isbn, ano, tipoEspecifico));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Existem livros com informação incompleta.");
                        return;
                    }
                }
            }
            }
        }
        public void CreateNewCliente(int id, string nome, int idade, int livrosRequisitados, string tipo, string dependsOnType)
        {
            Clientes novoCliente;

            switch (tipo)
            {
                case "LeitorComum":
                    novoCliente = new LeitorComum(id, nome, idade, livrosRequisitados);
                    break;
                case "Senior":
                    int anosRegistro = Convert.ToInt32(dependsOnType);
                    novoCliente = new Senior(id, nome, idade, livrosRequisitados, anosRegistro);
                    break;
                case "Estudante":
                    string instituicao = dependsOnType;
                    novoCliente = new Estudante(id, nome, idade, livrosRequisitados, instituicao);
                    break;
                case "Professor":
                    string disciplina = dependsOnType;
                    novoCliente = new Professor(id, nome, idade, livrosRequisitados, disciplina);
                    break;
                default:
                    throw new ArgumentException("Tipo de cliente desconhecido.");
            }
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
                        writer.WriteLine($"{cliente.ID};{cliente.Nome};{cliente.Idade};{cliente.LivrosRequisitados};{senior.AnosRegistro}");
                    }
                    else if (cliente is Estudante estudante)
                    {
                        writer.WriteLine($"{cliente.ID};{cliente.Nome};{cliente.Idade};{cliente.LivrosRequisitados};{estudante.Instituicao}");
                    }
                    else if (cliente is Professor professor)
                    {
                        writer.WriteLine($"{cliente.ID};{cliente.Nome};{cliente.Idade};{cliente.LivrosRequisitados};{professor.Disciplina}");
                    }
                    else
                    {
                        writer.WriteLine($"{cliente.ID};{cliente.Nome};{cliente.Idade};{cliente.LivrosRequisitados}");
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
                        var dados = linha.Split(';');
                        int id = int.Parse(dados[0]);
                        string nome = dados[1];
                        int idade = int.Parse(dados[2]);
                        int livrosRequisitados = int.Parse(dados[3]);

                        if (dados.Length == 5)
                        {
                            string tipoEspecifico = dados[4];

                            if (tipoEspecifico.Contains("AnosRegistro"))
                            {
                                Clientes.clientes.Add(new Senior(id, nome, idade, livrosRequisitados, int.Parse(tipoEspecifico)));
                            }
                            else if (tipoEspecifico.Contains("Instituicao"))
                            {
                                Clientes.clientes.Add(new Estudante(id, nome, idade, livrosRequisitados, tipoEspecifico));
                            }
                            else if (tipoEspecifico.Contains("Disciplina"))
                            {
                                Clientes.clientes.Add(new Professor(id, nome, idade, livrosRequisitados, tipoEspecifico));
                            }
                        }
                        else
                        {
                            Clientes.clientes.Add(new Clientes(id, nome, idade, livrosRequisitados, limitelivros: 5, descontomulta: 0.5, valorbasemulta: 1.5, limitereservas: 8, prioridade: 2.0));
                        }
                    }
                }
            }
        }

    }
}
