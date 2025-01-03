
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


        private void InitializeSearchForm()
        {
          

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
            int id = Clientes.clientes.Count + 1; // Auto-incremented
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


        private void guardarSearch_btn_Click(object sender, EventArgs e)
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



        private void search_dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = search_dataGridView.Rows[e.RowIndex];
                string originalISBN = row.Cells["ISBN"].Value.ToString();

                // Find the book in the list and update its details
                Livro bookToUpdate = Livro.Livros.FirstOrDefault(l => l.ISBN == originalISBN);
                if (bookToUpdate != null)
                {
                    bookToUpdate.Titulo = row.Cells["Titulo"].Value.ToString();
                    bookToUpdate.Autor = row.Cells["Autor"].Value.ToString();
                    bookToUpdate.ISBN = row.Cells["ISBN"].Value.ToString();
                    bookToUpdate.Ano = int.Parse(row.Cells["Ano"].Value.ToString());
                    // Update other properties based on the type of book
                    // ...

                    // Save the updated list to the file
                    gestor.SalvarLivroTxt("livros.txt");

                    MessageBox.Show("Book details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                    // Update other properties based on the type of book
                    // ...
                }
            }

            // Save the updated list to the file
            gestor.SalvarLivroTxt("livros.txt");

            MessageBox.Show("Book details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void search_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
