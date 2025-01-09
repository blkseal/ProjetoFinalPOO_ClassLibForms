
using Forms;
using gestaobiblioteca;



namespace gestaobilbliotecaFINAL
{
    public partial class Form1 : Form
    {
        Forms.Gestor gestor = new Forms.Gestor();
        public Form1()
        {
            InitializeComponent();
            InitializeSearchForm();
        }


        private readonly Dictionary<string, string> bookTypeMapping = new Dictionary<string, string>
{
    { "Jornal", "Jornal" },
    { "Livro Educativo", "LivroEducativo" },
    { "Livro Cientifico", "LivroCientifico" },
    { "Livro de Ficção", "LivroFiccao" },
    { "Revista", "Revista" }
};

        private readonly Dictionary<string, string> readerTypeMapping = new Dictionary<string, string>
{
    { "Leitor Comum", "LeitorComum" },
    { "Estudante", "Estudante" },
    { "Professor", "Professor" },
    { "Leitor Senior", "Senior" }
};


        private void InitializeSearchForm()
        {


            // Initialize ComboBox with book types
            typeLeitorSearch_comboBox.Items.AddRange(new string[] { "Leitor Comum", "Estudante", "Professor", "Leitor Senior" });
            typeLeitorSearch_comboBox.SelectedIndex = 0; // Default to the first item

            // Initialize ComboBox with search parameters for books
            searchLeitorParameter_ComboBox.Items.AddRange(new string[] { "ID", "Nome", "Idade" });
            searchLeitorParameter_ComboBox.SelectedIndex = 0; // Default to the first item

            // Initialize ComboBox with book types
            typeSearch_comboBox.Items.AddRange(new string[] { "Jornal", "Livro Educativo", "Livro Cientifico", "Livro de Ficção", "Revista" });
            typeSearch_comboBox.SelectedIndex = 0; // Default to the first item

            // Initialize ComboBox with search parameters for books
            searchParameter_ComboBox.Items.AddRange(new string[] { "Titulo", "Autor", "Ano", "ISBN" });
            searchParameter_ComboBox.SelectedIndex = 0; // Default to the first item



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gestor.LerLivroTxt("livros.txt");
            gestor.LerClienteTxt("clientes.txt");
            gestor.LerReservasTxt("reservas.txt");
            gestor.LerEmprestimosTxt("emprestimos.txt");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void regist_Books_TabPage_Click(object sender, EventArgs e)
        {

        }

        private void dependsOnType_label_Click(object sender, EventArgs e)
        {
        }

        private void tipo_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = tipo_ComboBox.Text;

            switch (choice)
            {
                case "Revista":
                    dependsOnType_label.Text = "Número de Edição:";
                    break;
                case "Educativo":
                    dependsOnType_label.Text = "Ano de Escolaridade:";
                    break;
                case "Ficção":
                    dependsOnType_label.Text = "Gênero:";
                    break;
                case "Cientifico":
                    dependsOnType_label.Text = "Área:";
                    break;
                case "Jornal":
                    dependsOnType_label.Text = "Dia de Edição:";
                    break;
            }
        }

        private void regist_Books_clearBtn_Click(object sender, EventArgs e)
        {
            tipo_ComboBox.Text = "";
            ISBN_txtbox.Text = "";
            Autor_txtbox.Text = "";
            Titulo_txtbox.Text = "";
            Ano_txtbox.Text = "";
            dependsOnType_txtbox.Text = "";
            dependsOnType_label.Text = "";
        }

        private void regist_Books_saveBtn_Click(object sender, EventArgs e)
        {
            // Check if any of the text boxes or combo box are empty
            if (string.IsNullOrWhiteSpace(Titulo_txtbox.Text) ||
        string.IsNullOrWhiteSpace(Autor_txtbox.Text) ||
        string.IsNullOrWhiteSpace(ISBN_txtbox.Text) ||
        string.IsNullOrWhiteSpace(Ano_txtbox.Text) ||
        string.IsNullOrWhiteSpace(tipo_ComboBox.Text) ||
        string.IsNullOrWhiteSpace(dependsOnType_txtbox.Text))
            {
                MessageBox.Show("Por favor preencha tudo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Proceed with creating the new book
                string titulo = Titulo_txtbox.Text;
                string autor = Autor_txtbox.Text;
                string isbn = ISBN_txtbox.Text;
                int anoPublicacao = int.Parse(Ano_txtbox.Text);
                string tipo = tipo_ComboBox.SelectedItem.ToString();
                string dependsOnType = dependsOnType_txtbox.Text;

                gestor.CreateNewBook(titulo, autor, isbn, anoPublicacao, tipo, dependsOnType);
                gestor.SalvarLivroTxt("livros.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tipoLeitor_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = tipoLeitor_ComboBox.Text;

            switch (choice)
            {
                case "Estudante":
                    dependsOnTypeLeitor_label.Text = "Instituição:";
                    break;
                case "Professor":
                    dependsOnTypeLeitor_label.Text = "Disciplina:";
                    break;
                case "Senior":
                    dependsOnTypeLeitor_label.Text = "Anos de registo:";
                    break;
                case "Comum":
                    dependsOnTypeLeitor_label.Text = "Nr de Cartão";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if any of the text boxes or combo box are empty
            if (string.IsNullOrWhiteSpace(nomeLeitor_txtbox.Text) ||
                string.IsNullOrWhiteSpace(idadeLeitor_txtbox.Text) ||
                string.IsNullOrWhiteSpace(livrosRequisitados_txtbox.Text) ||
                string.IsNullOrWhiteSpace(tipoLeitor_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(dependsOnTypeLeitor_txtbox.Text))
            {
                MessageBox.Show("Por favor preencha tudo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed with creating Client
            int id = Leitor.clientes.Count + 1; // Auto-incremented
            string nome = nomeLeitor_txtbox.Text;
            int idade = int.Parse(idadeLeitor_txtbox.Text);
            int livrosRequisitados = int.Parse(livrosRequisitados_txtbox.Text);
            string tipo = tipoLeitor_ComboBox.SelectedItem.ToString();
            string dependsOnType = dependsOnTypeLeitor_txtbox.Text;

            gestor.CreateNewCliente(id, nome, idade, livrosRequisitados, tipo, dependsOnType);
            gestor.SalvarClienteTxt("clientes.txt");
        }

        private void clearLeitor_btn_Click(object sender, EventArgs e)
        {
            tipoLeitor_ComboBox.Text = "";
            nomeLeitor_txtbox.Text = "";
            idadeLeitor_txtbox.Text = "";
            livrosRequisitados_txtbox.Text = "";
            dependsOnTypeLeitor_txtbox.Text = "";
            dependsOnTypeLeitor_label.Text = "";

        }


        private void guardarSearch_btn_Click(object sender, EventArgs e) // Btn pesquisar. TAB de pesquisa
        {
            // Get the selected book type and search parameter
            string bookType = typeSearch_comboBox.SelectedItem.ToString();
            string searchParameter = searchParameter_ComboBox.SelectedItem.ToString();
            string searchTerm = search_txtbox.Text;

            // Perform the search
            var matchingBooks = SearchBooks(bookType, searchParameter, searchTerm);

            // Display the results in the DataGridView

            search_dataGridView.DataSource = matchingBooks;
        }


        private List<Livro> SearchBooks(string bookType, string searchParameter, string searchTerm)
        {
            // Get the correct class name from the dictionary
            if (!bookTypeMapping.TryGetValue(bookType, out string className))
            {
                // If the book type is not found in the dictionary, return an empty list
                return new List<Livro>();
            }

            // Perform the search based on the selected criteria
            return Livro.Livros.Where(l => l.GetType().Name == className &&
                (searchParameter == "Titulo" && l.Titulo.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                 searchParameter == "Autor" && l.Autor.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                 searchParameter == "Ano" && l.Ano.ToString().Contains(searchTerm) ||
                 searchParameter == "ISBN" && l.ISBN.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)))
                .ToList();
        }


        private string GetDependsOnType(Livro livro)
        {
            return livro switch
            {
                LivroCientifico lc => lc.Area,
                LivroEducativo le => le.AnoEscolaridade.ToString(),
                LivroFiccao lf => lf.Categoria,
                Revista r => r.NumEdicao.ToString(),
                Jornal j => j.Dia.ToString(),
                _ => string.Empty
            };
        }


        private void clearSearch_btn_Click(object sender, EventArgs e)
        {
            // Clear search fields
            typeSearch_comboBox.SelectedIndex = 0;
            searchParameter_ComboBox.SelectedIndex = 0;
            search_txtbox.Text = "";
            search_dataGridView.DataSource = null;
        }





        private void saveBook_btn_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in search_dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                string originalISBN = row.Cells["ISBN"].Value.ToString();

                // Find the book in the list and update its details
                Livro bookToUpdate = Livro.Livros.FirstOrDefault(l => l.ISBN == originalISBN);
                if (bookToUpdate != null)
                {
                    bookToUpdate.Titulo = row.Cells["Titulo"].Value.ToString();
                    bookToUpdate.Autor = row.Cells["Autor"].Value.ToString();
                    bookToUpdate.ISBN = row.Cells["ISBN"].Value.ToString();
                    bookToUpdate.Ano = int.Parse(row.Cells["Ano"].Value.ToString());
                }
            }

            // Save the updated list to the file
            gestor.SalvarLivroTxt("livros.txt");
            MessageBox.Show("Book details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editBook_btn_Click(object sender, EventArgs e)
        {
            if (search_dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = search_dataGridView.SelectedRows[0];
                string isbn = selectedRow.Cells["ISBN"].Value.ToString();

                Livro bookToEdit = Livro.Livros.FirstOrDefault(l => l.ISBN == isbn);
                if (bookToEdit != null)
                {
                    // Populate the "Registar Livros" tab with the book's information
                    Titulo_txtbox.Text = bookToEdit.Titulo;
                    Autor_txtbox.Text = bookToEdit.Autor;
                    ISBN_txtbox.Text = bookToEdit.ISBN;
                    Ano_txtbox.Text = bookToEdit.Ano.ToString();
                    tipo_ComboBox.SelectedItem = bookToEdit.GetType().Name.Replace("Livro", "");

                    dependsOnType_txtbox.Text = GetDependsOnType(bookToEdit);

                    // Switch to the "Registar Livros" tab
                    dashboard.SelectedTab = regist_Books_TabPage;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um livro para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editBookSave_btn_Click(object sender, EventArgs e)
        {
            // Check if any of the text boxes or combo box are empty
            if (string.IsNullOrWhiteSpace(Titulo_txtbox.Text) ||
                string.IsNullOrWhiteSpace(Autor_txtbox.Text) ||
                string.IsNullOrWhiteSpace(ISBN_txtbox.Text) ||
                string.IsNullOrWhiteSpace(Ano_txtbox.Text) ||
                string.IsNullOrWhiteSpace(tipo_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(dependsOnType_txtbox.Text))
            {
                MessageBox.Show("Por favor preencha tudo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed with updating the book
            string titulo = Titulo_txtbox.Text;
            string autor = Autor_txtbox.Text;
            string isbn = ISBN_txtbox.Text;
            int anoPublicacao = int.Parse(Ano_txtbox.Text);
            string tipo = tipo_ComboBox.SelectedItem.ToString();
            string dependsOnType = dependsOnType_txtbox.Text;

            Livro bookToUpdate = Livro.Livros.FirstOrDefault(l => l.ISBN == isbn);
            if (bookToUpdate != null)
            {
                // Remove the old book
                Livro.Livros.Remove(bookToUpdate);

                // Create a new book with the updated information
                gestor.CreateNewBook(titulo, autor, isbn, anoPublicacao, tipo, dependsOnType);

                // Save the updated list to the file
                gestor.SalvarLivroTxt("livros.txt");
            }
            else
            {
                MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pesquisarLeitorSearch_btn_Click(object sender, EventArgs e)
        {
            // Get the selected reader type and search parameter
            string readerType = typeLeitorSearch_comboBox.SelectedItem.ToString();
            string searchParameter = searchLeitorParameter_ComboBox.SelectedItem.ToString();
            string searchTerm = searchLeitor_txtbox.Text;

            // Perform the search
            var matchingReaders = SearchReaders(readerType, searchParameter, searchTerm);

            // Display the results in the DataGridView
            search_Leitores_dataGridView.DataSource = matchingReaders;
        }


        private List<Leitor> SearchReaders(string readerType, string searchParameter, string searchTerm)
        {
            // Get the correct class name from the dictionary
            if (!readerTypeMapping.TryGetValue(readerType, out string className))
            {
                return new List<Leitor>();
            }

            // Perform the search based on the selected criteria
            return Leitor.clientes.Where(l => l.GetType().Name == className &&
                (searchParameter == "Nome" && l.Nome.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                 searchParameter == "ID" && l.ID.ToString().Contains(searchTerm) ||
                 searchParameter == "Idade" && l.Idade.ToString().Contains(searchTerm)))
                .ToList();
        }




        private string GetDependsOnType(Leitor reader)
        {
            return reader switch
            {
                Senior s => s.AnosRegistro.ToString(),
                Estudante e => e.Instituicao,
                Professor p => p.Disciplina,
                LeitorComum l => l.nrCartao.ToString(),
                _ => string.Empty
            };
        }
        private void clearLeitorSearch_btn_Click(object sender, EventArgs e)
        {
            typeLeitorSearch_comboBox.Text = "";
            searchLeitorParameter_ComboBox.Text = "";
            searchLeitor_txtbox.Text = "";

            search_Leitores_dataGridView.DataSource = null;
        }

        private void editLeitor_btn_Click_1(object sender, EventArgs e) // TAB PESQUISA
        {
            if (search_Leitores_dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = search_Leitores_dataGridView.SelectedRows[0];
                int id = int.Parse(selectedRow.Cells["ID"].Value.ToString());

                Leitor readerToEdit = Leitor.clientes.FirstOrDefault(c => c.ID == id);
                if (readerToEdit != null)
                {
                    // Populate the "Registar Leitores" tab with the reader's information
                    nomeLeitor_txtbox.Text = readerToEdit.Nome;
                    idadeLeitor_txtbox.Text = readerToEdit.Idade.ToString();
                    livrosRequisitados_txtbox.Text = readerToEdit.LivrosRequisitados.ToString();
                    tipoLeitor_ComboBox.SelectedItem = readerToEdit.GetType().Name.Replace("Leitor", "");

                    dependsOnTypeLeitor_txtbox.Text = GetDependsOnType(readerToEdit);

                    // Switch to the "Registar Leitores" tab
                    dashboard.SelectedTab = regist_Reader_TabPage;

                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um leitor para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editLeitor_btn1_Click(object sender, EventArgs e) // TAB REGISTO
        {

            // Check if any of the text boxes or combo box are empty
            if (string.IsNullOrWhiteSpace(nomeLeitor_txtbox.Text) ||
                string.IsNullOrWhiteSpace(idadeLeitor_txtbox.Text) ||
                string.IsNullOrWhiteSpace(livrosRequisitados_txtbox.Text) ||
                string.IsNullOrWhiteSpace(tipoLeitor_ComboBox.Text) ||
                string.IsNullOrWhiteSpace(dependsOnTypeLeitor_txtbox.Text))
            {
                MessageBox.Show("Por favor preencha tudo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed with updating the reader
            string nome = nomeLeitor_txtbox.Text;
            int idade = int.Parse(idadeLeitor_txtbox.Text);
            int livrosRequisitados = int.Parse(livrosRequisitados_txtbox.Text);
            string tipo = tipoLeitor_ComboBox.SelectedItem.ToString();
            string dependsOnType = dependsOnTypeLeitor_txtbox.Text;

            int id = int.Parse(search_Leitores_dataGridView.SelectedRows[0].Cells["ID"].Value.ToString());
            Leitor readerToUpdate = Leitor.clientes.FirstOrDefault(c => c.ID == id);
            if (readerToUpdate != null)
            {
                // Remove the old reader
                Leitor.clientes.Remove(readerToUpdate);

                // Create a new reader with the updated information
                gestor.CreateNewCliente(id, nome, idade, livrosRequisitados, tipo, dependsOnType);

                // Save the updated list to the file
                gestor.SalvarClienteTxt("clientes.txt");

                MessageBox.Show("Reader details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Reader not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveLeitor_btn_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in search_Leitores_dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                int originalID = int.Parse(row.Cells["ID"].Value.ToString());

                // Find the reader in the list and update its details
                Leitor readerToUpdate = Leitor.clientes.FirstOrDefault(c => c.ID == originalID);
                if (readerToUpdate != null)
                {
                    readerToUpdate.Nome = row.Cells["Nome"].Value.ToString();
                    readerToUpdate.Idade = int.Parse(row.Cells["Idade"].Value.ToString());
                    readerToUpdate.LivrosRequisitados = int.Parse(row.Cells["LivrosRequisitados"].Value.ToString());

                }
            }

            // Save the updated list to the file
            gestor.SalvarClienteTxt("clientes.txt");

            MessageBox.Show("Reader details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void deleteBook_btn_Click(object sender, EventArgs e)
        {
            if (search_dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = search_dataGridView.SelectedRows[0];
                string isbn = selectedRow.Cells["ISBN"].Value.ToString();

                Livro bookToDelete = Livro.Livros.FirstOrDefault(l => l.ISBN == isbn);
                if (bookToDelete != null)
                {
                    // Remove the book from the list
                    Livro.Livros.Remove(bookToDelete);

                    // Save the updated list to the file
                    gestor.SalvarLivroTxt("livros.txt");

                    // Refresh the DataGridView
                    guardarSearch_btn_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteCliente_btn_Click(object sender, EventArgs e)
        {
            if (search_Leitores_dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = search_Leitores_dataGridView.SelectedRows[0];
                int id = int.Parse(selectedRow.Cells["ID"].Value.ToString());

                Leitor clienteToDelete = Leitor.clientes.FirstOrDefault(c => c.ID == id);
                if (clienteToDelete != null)
                {
                    // Remove the cliente from the list
                    Leitor.clientes.Remove(clienteToDelete);

                    // Save the updated list to the file
                    gestor.SalvarClienteTxt("clientes.txt");

                    // Refresh the DataGridView
                    pesquisarLeitorSearch_btn_Click(null, null);

                }
                else
                {
                    MessageBox.Show("Cliente not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a cliente to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reservar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(idLeitor_txtbox.Text) || string.IsNullOrWhiteSpace(isbnLivro_txtbox.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(idLeitor_txtbox.Text, out int clienteID))
                {
                    MessageBox.Show("ID do leitor inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string livroID = isbnLivro_txtbox.Text;


                // Attempt to reserve the book
                gestor.ReservarLivro(livroID, clienteID);
                gestor.SalvarReservasTxt("reservas.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao reservar livro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void limparReserva_btn_Click(object sender, EventArgs e)
        {
            idLeitor_txtbox.Text = "";
            isbnLivro_txtbox.Text = "";
        }

        private List<Emprestimo> emprestimos = new List<Emprestimo>();

        private void emprestar_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                int leitorID = int.Parse(idLeitorEmprestar_txtbox.Text);
                string livroISBN = isbnLivroEmprestar_txtbox.Text;

                Leitor cliente = Leitor.clientes.FirstOrDefault(c => c.ID == leitorID);
                Livro livro = Livro.Livros.FirstOrDefault(l => l.ISBN == livroISBN);

                if (cliente == null)
                {
                    MessageBox.Show("Leitor não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (livro == null)
                {
                    MessageBox.Show("Livro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!livro.Disponivel)
                {
                    MessageBox.Show("Livro não está disponível.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cliente.LivrosRequisitados >= cliente.LimiteLivros)
                {
                    MessageBox.Show("Limite de empréstimos atingido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Emprestimo novoEmprestimo = new Emprestimo(cliente, livro, DateTime.Now);
                Emprestimo.Emprestimos.Add(novoEmprestimo);
                livro.Disponivel = false;
                cliente.LivrosRequisitados++;

                gestor.SalvarEmprestimosTxt("emprestimos.txt");

                MessageBox.Show("Empréstimo criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao criar empréstimo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void devolver_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int leitorID = int.Parse(idLeitorEmprestar_txtbox.Text);
                string livroISBN = isbnLivroEmprestar_txtbox.Text;

                Emprestimo emprestimo = Emprestimo.Emprestimos.FirstOrDefault(e => e.Cliente.ID == leitorID && e.LivroEmprestado.ISBN == livroISBN);

                if (emprestimo == null)
                {
                    MessageBox.Show("Empréstimo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                emprestimo.ProcessarDevolucao();
                Emprestimo.Emprestimos.Remove(emprestimo);
                emprestimo.LivroEmprestado.Disponivel = true;
                emprestimo.Cliente.LivrosRequisitados--;

                if (emprestimo.Multa > 0)
                {
                    MessageBox.Show($"Devolução processada com sucesso! Multa aplicada: {emprestimo.Multa:F2} EUR", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Devolução processada com sucesso! Nenhuma multa aplicada.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                gestor.SalvarEmprestimosTxt("emprestimos.txt");

                // Notify the next reader holding a reservation for this book
                gestor.NotificarProximoLeitor(livroISBN);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao processar devolução: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void pesquisarEmprestimosLeitor_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int readerID = int.Parse(idLeitorEmprestar_txtbox.Text);

                Leitor reader = Leitor.clientes.FirstOrDefault(c => c.ID == readerID);

                if (reader == null)
                {
                    MessageBox.Show("Leitor não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var loanHistory = Emprestimo.Emprestimos.Where(e => e.Cliente.ID == readerID).Select(e => new
                {
                    e.LivroEmprestado.Titulo,
                    e.LivroEmprestado.ISBN,
                    e.DataEmprestimo,
                    e.DataDevolucao,
                    Multa = e.Multa > 0 ? $"{e.Multa:F2} EUR" : "Nenhuma"
                }).ToList();

                emprestimos_dgv.DataSource = loanHistory;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao buscar histórico de empréstimos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GerarRelatorioEmprestimos()
        {
            var dadosRelatorio = new List<dynamic>();

            var agrupadosPorTipoLivro = Emprestimo.Emprestimos.GroupBy(e => e.LivroEmprestado.GetType().Name);

            foreach (var grupo in agrupadosPorTipoLivro)
            {
                var tipoLeitorMaisFrequente = grupo.GroupBy(e => e.Cliente.GetType().Name)
                                                   .OrderByDescending(gg => gg.Count())
                                                   .First().Key;

                dadosRelatorio.Add(new
                {
                    TipoLivro = grupo.Key,
                    TotalEmprestimos = grupo.Count(),
                    TipoLeitorMaisRequisitado = tipoLeitorMaisFrequente
                });
            }

            relatorioEmprestimos_dgv.DataSource = dadosRelatorio;
        }

        private void relatorioEmprestimos_btn_Click(object sender, EventArgs e)
        {
            GerarRelatorioEmprestimos();
        }

        private void GerarRelatorioMultasPendentes()
        {
            var dadosRelatorio = new List<dynamic>();

            var agrupadosPorTipoLeitor = Emprestimo.Emprestimos.Where(e => e.Multa > 0)
                                                               .GroupBy(e => e.Cliente.GetType().Name);

            foreach (var grupo in agrupadosPorTipoLeitor)
            {
                foreach (var emprestimo in grupo)
                {
                    dadosRelatorio.Add(new
                    {
                        TipoLeitor = grupo.Key,
                        Multa = emprestimo.Multa,
                        NomeLeitor = emprestimo.Cliente.Nome,
                        IdLeitor = emprestimo.Cliente.ID
                    });
                }
            }

            dadosRelatorio = dadosRelatorio.OrderBy(d => d.TipoLeitor).ToList();
            relatorioMultas_dgv.DataSource = dadosRelatorio;
        }

        private void relatorioMultas_btn_Click(object sender, EventArgs e)
        {
            GerarRelatorioMultasPendentes();
        }

        private void prorrogar_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int leitorID = int.Parse(idLeitorEmprestar_txtbox.Text);
                string livroISBN = isbnLivroEmprestar_txtbox.Text;
                int diasProrrogacao = int.Parse(diasProrrogar_txtbox.Text);

                Emprestimo emprestimo = Emprestimo.Emprestimos.FirstOrDefault(e => e.Cliente.ID == leitorID && e.LivroEmprestado.ISBN == livroISBN);

                if (emprestimo == null)
                {
                    MessageBox.Show("Empréstimo não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (emprestimo.ProrrogarEmprestimo(diasProrrogacao))
                {
                    MessageBox.Show("Empréstimo prorrogado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gestor.SalvarEmprestimosTxt("emprestimos.txt");
                }
                else
                {
                    MessageBox.Show("Este leitor não tem permissão para prorrogar empréstimos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao prorrogar empréstimo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void notificarLeitores_btn_Click(object sender, EventArgs e)
        {
            Emprestimo.EnviarNotificacoesAtraso();
            MessageBox.Show("Notificações de atraso enviadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}




