
namespace gestaobilbliotecaFINAL
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dashboard = new TabControl();
            regist_Books_TabPage = new TabPage();
            editBookSave_btn = new Button();
            regist_Books_clearBtn = new Button();
            regist_Books_saveBtn = new Button();
            dependsOnType_label = new Label();
            dependsOnType_txtbox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ISBN_txtbox = new TextBox();
            Ano_txtbox = new TextBox();
            Autor_txtbox = new TextBox();
            Titulo_txtbox = new TextBox();
            tipo_ComboBox = new ComboBox();
            regist_Reader_TabPage = new TabPage();
            editLeitor_btn1 = new Button();
            label6 = new Label();
            livrosRequisitados_txtbox = new TextBox();
            label8 = new Label();
            idadeLeitor_txtbox = new TextBox();
            clearLeitor_btn = new Button();
            guardarLeitor_btn = new Button();
            dependsOnTypeLeitor_label = new Label();
            dependsOnTypeLeitor_txtbox = new TextBox();
            label7 = new Label();
            label11 = new Label();
            nomeLeitor_txtbox = new TextBox();
            tipoLeitor_ComboBox = new ComboBox();
            manage_Loans_TabPage = new TabPage();
            label20 = new Label();
            diasProrrogar_txtbox = new TextBox();
            prorrogar_btn = new Button();
            pesquisarEmprestimosLeitor_btn = new Button();
            emprestimos_dgv = new DataGridView();
            label18 = new Label();
            isbnLivroEmprestar_txtbox = new TextBox();
            devolver_btn = new Button();
            emprestar_Btn = new Button();
            label19 = new Label();
            idLeitorEmprestar_txtbox = new TextBox();
            settings_TabPage = new TabPage();
            label17 = new Label();
            isbnLivro_txtbox = new TextBox();
            limparReserva_btn = new Button();
            reservar_btn = new Button();
            label16 = new Label();
            idLeitor_txtbox = new TextBox();
            search_Books_TabPage = new TabPage();
            deleteBook_btn = new Button();
            editBook_btn = new Button();
            search_dataGridView = new DataGridView();
            saveBook_btn = new Button();
            label12 = new Label();
            searchParameter_ComboBox = new ComboBox();
            clearSearch_btn = new Button();
            pesquisarSearch_btn = new Button();
            label10 = new Label();
            search_txtbox = new TextBox();
            label9 = new Label();
            typeSearch_comboBox = new ComboBox();
            search_Readers_TabPage = new TabPage();
            deleteCliente_btn = new Button();
            editLeitor_btn = new Button();
            search_Leitores_dataGridView = new DataGridView();
            saveLeitor_btn = new Button();
            label13 = new Label();
            searchLeitorParameter_ComboBox = new ComboBox();
            clearLeitorSearch_btn = new Button();
            pesquisarLeitorSearch_btn = new Button();
            label14 = new Label();
            searchLeitor_txtbox = new TextBox();
            label15 = new Label();
            typeLeitorSearch_comboBox = new ComboBox();
            return_Books_TabPage = new TabPage();
            relatorioMultas_btn = new Button();
            relatorioMultas_dgv = new DataGridView();
            relatorioEmprestimos_btn = new Button();
            relatorioEmprestimos_dgv = new DataGridView();
            notificarLeitores_btn = new Button();
            dashboard.SuspendLayout();
            regist_Books_TabPage.SuspendLayout();
            regist_Reader_TabPage.SuspendLayout();
            manage_Loans_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emprestimos_dgv).BeginInit();
            settings_TabPage.SuspendLayout();
            search_Books_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)search_dataGridView).BeginInit();
            search_Readers_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)search_Leitores_dataGridView).BeginInit();
            return_Books_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)relatorioMultas_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)relatorioEmprestimos_dgv).BeginInit();
            SuspendLayout();
            // 
            // dashboard
            // 
            dashboard.Controls.Add(regist_Books_TabPage);
            dashboard.Controls.Add(regist_Reader_TabPage);
            dashboard.Controls.Add(manage_Loans_TabPage);
            dashboard.Controls.Add(settings_TabPage);
            dashboard.Controls.Add(search_Books_TabPage);
            dashboard.Controls.Add(search_Readers_TabPage);
            dashboard.Controls.Add(return_Books_TabPage);
            dashboard.Location = new Point(12, 12);
            dashboard.Name = "dashboard";
            dashboard.SelectedIndex = 0;
            dashboard.Size = new Size(944, 573);
            dashboard.TabIndex = 0;
            // 
            // regist_Books_TabPage
            // 
            regist_Books_TabPage.Controls.Add(editBookSave_btn);
            regist_Books_TabPage.Controls.Add(regist_Books_clearBtn);
            regist_Books_TabPage.Controls.Add(regist_Books_saveBtn);
            regist_Books_TabPage.Controls.Add(dependsOnType_label);
            regist_Books_TabPage.Controls.Add(dependsOnType_txtbox);
            regist_Books_TabPage.Controls.Add(label5);
            regist_Books_TabPage.Controls.Add(label4);
            regist_Books_TabPage.Controls.Add(label3);
            regist_Books_TabPage.Controls.Add(label2);
            regist_Books_TabPage.Controls.Add(label1);
            regist_Books_TabPage.Controls.Add(ISBN_txtbox);
            regist_Books_TabPage.Controls.Add(Ano_txtbox);
            regist_Books_TabPage.Controls.Add(Autor_txtbox);
            regist_Books_TabPage.Controls.Add(Titulo_txtbox);
            regist_Books_TabPage.Controls.Add(tipo_ComboBox);
            regist_Books_TabPage.Location = new Point(4, 24);
            regist_Books_TabPage.Name = "regist_Books_TabPage";
            regist_Books_TabPage.Padding = new Padding(3);
            regist_Books_TabPage.Size = new Size(936, 545);
            regist_Books_TabPage.TabIndex = 0;
            regist_Books_TabPage.Text = "Registar Livros";
            regist_Books_TabPage.UseVisualStyleBackColor = true;
            regist_Books_TabPage.Click += regist_Books_TabPage_Click;
            // 
            // editBookSave_btn
            // 
            editBookSave_btn.Location = new Point(8, 299);
            editBookSave_btn.Name = "editBookSave_btn";
            editBookSave_btn.Size = new Size(216, 23);
            editBookSave_btn.TabIndex = 26;
            editBookSave_btn.Text = "Editar";
            editBookSave_btn.UseVisualStyleBackColor = true;
            editBookSave_btn.Click += editBookSave_btn_Click;
            // 
            // regist_Books_clearBtn
            // 
            regist_Books_clearBtn.Location = new Point(8, 270);
            regist_Books_clearBtn.Name = "regist_Books_clearBtn";
            regist_Books_clearBtn.Size = new Size(216, 23);
            regist_Books_clearBtn.TabIndex = 14;
            regist_Books_clearBtn.Text = "Limpar";
            regist_Books_clearBtn.UseVisualStyleBackColor = true;
            regist_Books_clearBtn.Click += regist_Books_clearBtn_Click;
            // 
            // regist_Books_saveBtn
            // 
            regist_Books_saveBtn.Location = new Point(8, 241);
            regist_Books_saveBtn.Name = "regist_Books_saveBtn";
            regist_Books_saveBtn.Size = new Size(216, 23);
            regist_Books_saveBtn.TabIndex = 13;
            regist_Books_saveBtn.Text = "Guardar";
            regist_Books_saveBtn.UseVisualStyleBackColor = true;
            regist_Books_saveBtn.Click += regist_Books_saveBtn_Click;
            // 
            // dependsOnType_label
            // 
            dependsOnType_label.AutoSize = true;
            dependsOnType_label.Location = new Point(243, 3);
            dependsOnType_label.Name = "dependsOnType_label";
            dependsOnType_label.Size = new Size(22, 15);
            dependsOnType_label.TabIndex = 12;
            dependsOnType_label.Text = "---";
            dependsOnType_label.Click += dependsOnType_label_Click;
            // 
            // dependsOnType_txtbox
            // 
            dependsOnType_txtbox.Location = new Point(243, 21);
            dependsOnType_txtbox.Name = "dependsOnType_txtbox";
            dependsOnType_txtbox.Size = new Size(215, 23);
            dependsOnType_txtbox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 47);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "Titulo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 179);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 8;
            label4.Text = "ISBN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 135);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 7;
            label3.Text = "Ano:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 91);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Autor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 5;
            label1.Text = "Tipo:";
            // 
            // ISBN_txtbox
            // 
            ISBN_txtbox.Location = new Point(8, 197);
            ISBN_txtbox.Name = "ISBN_txtbox";
            ISBN_txtbox.Size = new Size(215, 23);
            ISBN_txtbox.TabIndex = 4;
            // 
            // Ano_txtbox
            // 
            Ano_txtbox.Location = new Point(8, 153);
            Ano_txtbox.Name = "Ano_txtbox";
            Ano_txtbox.Size = new Size(215, 23);
            Ano_txtbox.TabIndex = 3;
            // 
            // Autor_txtbox
            // 
            Autor_txtbox.Location = new Point(8, 109);
            Autor_txtbox.Name = "Autor_txtbox";
            Autor_txtbox.Size = new Size(215, 23);
            Autor_txtbox.TabIndex = 2;
            // 
            // Titulo_txtbox
            // 
            Titulo_txtbox.Location = new Point(6, 65);
            Titulo_txtbox.Name = "Titulo_txtbox";
            Titulo_txtbox.Size = new Size(215, 23);
            Titulo_txtbox.TabIndex = 1;
            // 
            // tipo_ComboBox
            // 
            tipo_ComboBox.FormattingEnabled = true;
            tipo_ComboBox.Items.AddRange(new object[] { "Cientifico", "Educativo", "Ficção", "Revista", "Jornal" });
            tipo_ComboBox.Location = new Point(6, 21);
            tipo_ComboBox.Name = "tipo_ComboBox";
            tipo_ComboBox.Size = new Size(215, 23);
            tipo_ComboBox.TabIndex = 0;
            tipo_ComboBox.SelectedIndexChanged += tipo_ComboBox_SelectedIndexChanged;
            // 
            // regist_Reader_TabPage
            // 
            regist_Reader_TabPage.Controls.Add(editLeitor_btn1);
            regist_Reader_TabPage.Controls.Add(label6);
            regist_Reader_TabPage.Controls.Add(livrosRequisitados_txtbox);
            regist_Reader_TabPage.Controls.Add(label8);
            regist_Reader_TabPage.Controls.Add(idadeLeitor_txtbox);
            regist_Reader_TabPage.Controls.Add(clearLeitor_btn);
            regist_Reader_TabPage.Controls.Add(guardarLeitor_btn);
            regist_Reader_TabPage.Controls.Add(dependsOnTypeLeitor_label);
            regist_Reader_TabPage.Controls.Add(dependsOnTypeLeitor_txtbox);
            regist_Reader_TabPage.Controls.Add(label7);
            regist_Reader_TabPage.Controls.Add(label11);
            regist_Reader_TabPage.Controls.Add(nomeLeitor_txtbox);
            regist_Reader_TabPage.Controls.Add(tipoLeitor_ComboBox);
            regist_Reader_TabPage.Location = new Point(4, 24);
            regist_Reader_TabPage.Name = "regist_Reader_TabPage";
            regist_Reader_TabPage.Padding = new Padding(3);
            regist_Reader_TabPage.Size = new Size(936, 545);
            regist_Reader_TabPage.TabIndex = 1;
            regist_Reader_TabPage.Text = "Registar Leitores";
            regist_Reader_TabPage.UseVisualStyleBackColor = true;
            // 
            // editLeitor_btn1
            // 
            editLeitor_btn1.Location = new Point(6, 255);
            editLeitor_btn1.Name = "editLeitor_btn1";
            editLeitor_btn1.Size = new Size(216, 23);
            editLeitor_btn1.TabIndex = 33;
            editLeitor_btn1.Text = "Editar";
            editLeitor_btn1.UseVisualStyleBackColor = true;
            editLeitor_btn1.Click += editLeitor_btn1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 138);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 32;
            label6.Text = "Livros Requisitados:";
            // 
            // livrosRequisitados_txtbox
            // 
            livrosRequisitados_txtbox.Location = new Point(6, 156);
            livrosRequisitados_txtbox.Name = "livrosRequisitados_txtbox";
            livrosRequisitados_txtbox.Size = new Size(215, 23);
            livrosRequisitados_txtbox.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 92);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 30;
            label8.Text = "Idade:";
            // 
            // idadeLeitor_txtbox
            // 
            idadeLeitor_txtbox.Location = new Point(6, 110);
            idadeLeitor_txtbox.Name = "idadeLeitor_txtbox";
            idadeLeitor_txtbox.Size = new Size(215, 23);
            idadeLeitor_txtbox.TabIndex = 29;
            // 
            // clearLeitor_btn
            // 
            clearLeitor_btn.Location = new Point(6, 226);
            clearLeitor_btn.Name = "clearLeitor_btn";
            clearLeitor_btn.Size = new Size(216, 23);
            clearLeitor_btn.TabIndex = 28;
            clearLeitor_btn.Text = "Limpar";
            clearLeitor_btn.UseVisualStyleBackColor = true;
            clearLeitor_btn.Click += clearLeitor_btn_Click;
            // 
            // guardarLeitor_btn
            // 
            guardarLeitor_btn.Location = new Point(6, 197);
            guardarLeitor_btn.Name = "guardarLeitor_btn";
            guardarLeitor_btn.Size = new Size(216, 23);
            guardarLeitor_btn.TabIndex = 27;
            guardarLeitor_btn.Text = "Guardar";
            guardarLeitor_btn.UseVisualStyleBackColor = true;
            guardarLeitor_btn.Click += button2_Click;
            // 
            // dependsOnTypeLeitor_label
            // 
            dependsOnTypeLeitor_label.AutoSize = true;
            dependsOnTypeLeitor_label.Location = new Point(243, 3);
            dependsOnTypeLeitor_label.Name = "dependsOnTypeLeitor_label";
            dependsOnTypeLeitor_label.Size = new Size(22, 15);
            dependsOnTypeLeitor_label.TabIndex = 26;
            dependsOnTypeLeitor_label.Text = "---";
            // 
            // dependsOnTypeLeitor_txtbox
            // 
            dependsOnTypeLeitor_txtbox.Location = new Point(243, 21);
            dependsOnTypeLeitor_txtbox.Name = "dependsOnTypeLeitor_txtbox";
            dependsOnTypeLeitor_txtbox.Size = new Size(215, 23);
            dependsOnTypeLeitor_txtbox.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 47);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 24;
            label7.Text = "Nome:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 3);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 20;
            label11.Text = "Tipo:";
            // 
            // nomeLeitor_txtbox
            // 
            nomeLeitor_txtbox.Location = new Point(6, 65);
            nomeLeitor_txtbox.Name = "nomeLeitor_txtbox";
            nomeLeitor_txtbox.Size = new Size(215, 23);
            nomeLeitor_txtbox.TabIndex = 16;
            // 
            // tipoLeitor_ComboBox
            // 
            tipoLeitor_ComboBox.FormattingEnabled = true;
            tipoLeitor_ComboBox.Items.AddRange(new object[] { "Comum", "Professor", "Estudante", "Senior" });
            tipoLeitor_ComboBox.Location = new Point(6, 21);
            tipoLeitor_ComboBox.Name = "tipoLeitor_ComboBox";
            tipoLeitor_ComboBox.Size = new Size(215, 23);
            tipoLeitor_ComboBox.TabIndex = 15;
            tipoLeitor_ComboBox.SelectedIndexChanged += tipoLeitor_ComboBox_SelectedIndexChanged;
            // 
            // manage_Loans_TabPage
            // 
            manage_Loans_TabPage.Controls.Add(notificarLeitores_btn);
            manage_Loans_TabPage.Controls.Add(label20);
            manage_Loans_TabPage.Controls.Add(diasProrrogar_txtbox);
            manage_Loans_TabPage.Controls.Add(prorrogar_btn);
            manage_Loans_TabPage.Controls.Add(pesquisarEmprestimosLeitor_btn);
            manage_Loans_TabPage.Controls.Add(emprestimos_dgv);
            manage_Loans_TabPage.Controls.Add(label18);
            manage_Loans_TabPage.Controls.Add(isbnLivroEmprestar_txtbox);
            manage_Loans_TabPage.Controls.Add(devolver_btn);
            manage_Loans_TabPage.Controls.Add(emprestar_Btn);
            manage_Loans_TabPage.Controls.Add(label19);
            manage_Loans_TabPage.Controls.Add(idLeitorEmprestar_txtbox);
            manage_Loans_TabPage.Location = new Point(4, 24);
            manage_Loans_TabPage.Name = "manage_Loans_TabPage";
            manage_Loans_TabPage.Size = new Size(936, 545);
            manage_Loans_TabPage.TabIndex = 2;
            manage_Loans_TabPage.Text = "Empréstimos";
            manage_Loans_TabPage.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(11, 269);
            label20.Name = "label20";
            label20.Size = new Size(32, 15);
            label20.TabIndex = 33;
            label20.Text = "Dias:";
            // 
            // diasProrrogar_txtbox
            // 
            diasProrrogar_txtbox.Location = new Point(11, 287);
            diasProrrogar_txtbox.Name = "diasProrrogar_txtbox";
            diasProrrogar_txtbox.Size = new Size(186, 23);
            diasProrrogar_txtbox.TabIndex = 32;
            // 
            // prorrogar_btn
            // 
            prorrogar_btn.Location = new Point(11, 316);
            prorrogar_btn.Name = "prorrogar_btn";
            prorrogar_btn.Size = new Size(186, 23);
            prorrogar_btn.TabIndex = 31;
            prorrogar_btn.Text = "Prorrogar";
            prorrogar_btn.UseVisualStyleBackColor = true;
            prorrogar_btn.Click += prorrogar_btn_Click;
            // 
            // pesquisarEmprestimosLeitor_btn
            // 
            pesquisarEmprestimosLeitor_btn.Location = new Point(11, 156);
            pesquisarEmprestimosLeitor_btn.Name = "pesquisarEmprestimosLeitor_btn";
            pesquisarEmprestimosLeitor_btn.Size = new Size(186, 23);
            pesquisarEmprestimosLeitor_btn.TabIndex = 30;
            pesquisarEmprestimosLeitor_btn.Text = "Pesquisar (Leitor)";
            pesquisarEmprestimosLeitor_btn.UseVisualStyleBackColor = true;
            pesquisarEmprestimosLeitor_btn.Click += pesquisarEmprestimosLeitor_btn_Click;
            // 
            // emprestimos_dgv
            // 
            emprestimos_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            emprestimos_dgv.Location = new Point(468, 15);
            emprestimos_dgv.Name = "emprestimos_dgv";
            emprestimos_dgv.Size = new Size(367, 341);
            emprestimos_dgv.TabIndex = 29;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(11, 55);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(64, 15);
            label18.TabIndex = 28;
            label18.Text = "ISBN Livro:";
            // 
            // isbnLivroEmprestar_txtbox
            // 
            isbnLivroEmprestar_txtbox.Location = new Point(11, 71);
            isbnLivroEmprestar_txtbox.Margin = new Padding(2, 1, 2, 1);
            isbnLivroEmprestar_txtbox.Name = "isbnLivroEmprestar_txtbox";
            isbnLivroEmprestar_txtbox.Size = new Size(183, 23);
            isbnLivroEmprestar_txtbox.TabIndex = 27;
            // 
            // devolver_btn
            // 
            devolver_btn.Location = new Point(11, 127);
            devolver_btn.Name = "devolver_btn";
            devolver_btn.Size = new Size(183, 23);
            devolver_btn.TabIndex = 26;
            devolver_btn.Text = "Devolver";
            devolver_btn.UseVisualStyleBackColor = true;
            devolver_btn.Click += devolver_btn_Click;
            // 
            // emprestar_Btn
            // 
            emprestar_Btn.Location = new Point(11, 98);
            emprestar_Btn.Name = "emprestar_Btn";
            emprestar_Btn.Size = new Size(183, 23);
            emprestar_Btn.TabIndex = 25;
            emprestar_Btn.Text = "Emprestar";
            emprestar_Btn.UseVisualStyleBackColor = true;
            emprestar_Btn.Click += emprestar_Btn_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(11, 15);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(54, 15);
            label19.TabIndex = 24;
            label19.Text = "ID Leitor:";
            // 
            // idLeitorEmprestar_txtbox
            // 
            idLeitorEmprestar_txtbox.Location = new Point(11, 31);
            idLeitorEmprestar_txtbox.Margin = new Padding(2, 1, 2, 1);
            idLeitorEmprestar_txtbox.Name = "idLeitorEmprestar_txtbox";
            idLeitorEmprestar_txtbox.Size = new Size(183, 23);
            idLeitorEmprestar_txtbox.TabIndex = 23;
            // 
            // settings_TabPage
            // 
            settings_TabPage.Controls.Add(label17);
            settings_TabPage.Controls.Add(isbnLivro_txtbox);
            settings_TabPage.Controls.Add(limparReserva_btn);
            settings_TabPage.Controls.Add(reservar_btn);
            settings_TabPage.Controls.Add(label16);
            settings_TabPage.Controls.Add(idLeitor_txtbox);
            settings_TabPage.Location = new Point(4, 24);
            settings_TabPage.Name = "settings_TabPage";
            settings_TabPage.Size = new Size(936, 545);
            settings_TabPage.TabIndex = 5;
            settings_TabPage.Text = "Reservas";
            settings_TabPage.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(4, 49);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(64, 15);
            label17.TabIndex = 22;
            label17.Text = "ISBN Livro:";
            // 
            // isbnLivro_txtbox
            // 
            isbnLivro_txtbox.Location = new Point(4, 65);
            isbnLivro_txtbox.Margin = new Padding(2, 1, 2, 1);
            isbnLivro_txtbox.Name = "isbnLivro_txtbox";
            isbnLivro_txtbox.Size = new Size(183, 23);
            isbnLivro_txtbox.TabIndex = 21;
            // 
            // limparReserva_btn
            // 
            limparReserva_btn.Location = new Point(4, 121);
            limparReserva_btn.Name = "limparReserva_btn";
            limparReserva_btn.Size = new Size(183, 23);
            limparReserva_btn.TabIndex = 20;
            limparReserva_btn.Text = "Limpar";
            limparReserva_btn.UseVisualStyleBackColor = true;
            limparReserva_btn.Click += limparReserva_btn_Click;
            // 
            // reservar_btn
            // 
            reservar_btn.Location = new Point(4, 92);
            reservar_btn.Name = "reservar_btn";
            reservar_btn.Size = new Size(183, 23);
            reservar_btn.TabIndex = 19;
            reservar_btn.Text = "Reservar";
            reservar_btn.UseVisualStyleBackColor = true;
            reservar_btn.Click += reservar_btn_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(4, 9);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(54, 15);
            label16.TabIndex = 18;
            label16.Text = "ID Leitor:";
            // 
            // idLeitor_txtbox
            // 
            idLeitor_txtbox.Location = new Point(4, 25);
            idLeitor_txtbox.Margin = new Padding(2, 1, 2, 1);
            idLeitor_txtbox.Name = "idLeitor_txtbox";
            idLeitor_txtbox.Size = new Size(183, 23);
            idLeitor_txtbox.TabIndex = 17;
            // 
            // search_Books_TabPage
            // 
            search_Books_TabPage.Controls.Add(deleteBook_btn);
            search_Books_TabPage.Controls.Add(editBook_btn);
            search_Books_TabPage.Controls.Add(search_dataGridView);
            search_Books_TabPage.Controls.Add(saveBook_btn);
            search_Books_TabPage.Controls.Add(label12);
            search_Books_TabPage.Controls.Add(searchParameter_ComboBox);
            search_Books_TabPage.Controls.Add(clearSearch_btn);
            search_Books_TabPage.Controls.Add(pesquisarSearch_btn);
            search_Books_TabPage.Controls.Add(label10);
            search_Books_TabPage.Controls.Add(search_txtbox);
            search_Books_TabPage.Controls.Add(label9);
            search_Books_TabPage.Controls.Add(typeSearch_comboBox);
            search_Books_TabPage.Location = new Point(4, 24);
            search_Books_TabPage.Name = "search_Books_TabPage";
            search_Books_TabPage.Size = new Size(936, 545);
            search_Books_TabPage.TabIndex = 4;
            search_Books_TabPage.Text = "Procurar Livros";
            search_Books_TabPage.UseVisualStyleBackColor = true;
            // 
            // deleteBook_btn
            // 
            deleteBook_btn.Location = new Point(240, 438);
            deleteBook_btn.Name = "deleteBook_btn";
            deleteBook_btn.Size = new Size(571, 23);
            deleteBook_btn.TabIndex = 26;
            deleteBook_btn.Text = "Apagar";
            deleteBook_btn.UseVisualStyleBackColor = true;
            deleteBook_btn.Click += deleteBook_btn_Click;
            // 
            // editBook_btn
            // 
            editBook_btn.Location = new Point(240, 410);
            editBook_btn.Name = "editBook_btn";
            editBook_btn.Size = new Size(571, 23);
            editBook_btn.TabIndex = 25;
            editBook_btn.Text = "Editar";
            editBook_btn.UseVisualStyleBackColor = true;
            editBook_btn.Click += editBook_btn_Click;
            // 
            // search_dataGridView
            // 
            search_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            search_dataGridView.Location = new Point(240, 16);
            search_dataGridView.Margin = new Padding(2, 1, 2, 1);
            search_dataGridView.Name = "search_dataGridView";
            search_dataGridView.RowHeadersWidth = 82;
            search_dataGridView.Size = new Size(571, 365);
            search_dataGridView.TabIndex = 24;
            // 
            // saveBook_btn
            // 
            saveBook_btn.Location = new Point(240, 384);
            saveBook_btn.Margin = new Padding(2, 1, 2, 1);
            saveBook_btn.Name = "saveBook_btn";
            saveBook_btn.Size = new Size(571, 22);
            saveBook_btn.TabIndex = 21;
            saveBook_btn.Text = "Guardar";
            saveBook_btn.UseVisualStyleBackColor = true;
            saveBook_btn.Click += saveBook_btn_Click_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(0, 77);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(49, 15);
            label12.TabIndex = 19;
            label12.Text = "Critério:";
            // 
            // searchParameter_ComboBox
            // 
            searchParameter_ComboBox.FormattingEnabled = true;
            searchParameter_ComboBox.Location = new Point(0, 94);
            searchParameter_ComboBox.Margin = new Padding(2, 1, 2, 1);
            searchParameter_ComboBox.Name = "searchParameter_ComboBox";
            searchParameter_ComboBox.Size = new Size(183, 23);
            searchParameter_ComboBox.TabIndex = 18;
            // 
            // clearSearch_btn
            // 
            clearSearch_btn.Location = new Point(0, 198);
            clearSearch_btn.Name = "clearSearch_btn";
            clearSearch_btn.Size = new Size(181, 23);
            clearSearch_btn.TabIndex = 16;
            clearSearch_btn.Text = "Limpar";
            clearSearch_btn.UseVisualStyleBackColor = true;
            clearSearch_btn.Click += clearSearch_btn_Click;
            // 
            // pesquisarSearch_btn
            // 
            pesquisarSearch_btn.Location = new Point(0, 169);
            pesquisarSearch_btn.Name = "pesquisarSearch_btn";
            pesquisarSearch_btn.Size = new Size(181, 23);
            pesquisarSearch_btn.TabIndex = 15;
            pesquisarSearch_btn.Text = "Pesquisar";
            pesquisarSearch_btn.UseVisualStyleBackColor = true;
            pesquisarSearch_btn.Click += guardarSearch_btn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 118);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 3;
            label10.Text = "Termo:";
            // 
            // search_txtbox
            // 
            search_txtbox.Location = new Point(0, 134);
            search_txtbox.Margin = new Padding(2, 1, 2, 1);
            search_txtbox.Name = "search_txtbox";
            search_txtbox.Size = new Size(183, 23);
            search_txtbox.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(2, 37);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 1;
            label9.Text = "Tipo:";
            // 
            // typeSearch_comboBox
            // 
            typeSearch_comboBox.FormattingEnabled = true;
            typeSearch_comboBox.Location = new Point(2, 53);
            typeSearch_comboBox.Margin = new Padding(2, 1, 2, 1);
            typeSearch_comboBox.Name = "typeSearch_comboBox";
            typeSearch_comboBox.Size = new Size(183, 23);
            typeSearch_comboBox.TabIndex = 0;
            // 
            // search_Readers_TabPage
            // 
            search_Readers_TabPage.Controls.Add(deleteCliente_btn);
            search_Readers_TabPage.Controls.Add(editLeitor_btn);
            search_Readers_TabPage.Controls.Add(search_Leitores_dataGridView);
            search_Readers_TabPage.Controls.Add(saveLeitor_btn);
            search_Readers_TabPage.Controls.Add(label13);
            search_Readers_TabPage.Controls.Add(searchLeitorParameter_ComboBox);
            search_Readers_TabPage.Controls.Add(clearLeitorSearch_btn);
            search_Readers_TabPage.Controls.Add(pesquisarLeitorSearch_btn);
            search_Readers_TabPage.Controls.Add(label14);
            search_Readers_TabPage.Controls.Add(searchLeitor_txtbox);
            search_Readers_TabPage.Controls.Add(label15);
            search_Readers_TabPage.Controls.Add(typeLeitorSearch_comboBox);
            search_Readers_TabPage.Location = new Point(4, 24);
            search_Readers_TabPage.Name = "search_Readers_TabPage";
            search_Readers_TabPage.Size = new Size(936, 545);
            search_Readers_TabPage.TabIndex = 6;
            search_Readers_TabPage.Text = "Procurar Leitores";
            search_Readers_TabPage.UseVisualStyleBackColor = true;
            // 
            // deleteCliente_btn
            // 
            deleteCliente_btn.Location = new Point(240, 441);
            deleteCliente_btn.Name = "deleteCliente_btn";
            deleteCliente_btn.Size = new Size(571, 23);
            deleteCliente_btn.TabIndex = 37;
            deleteCliente_btn.Text = "Apagar";
            deleteCliente_btn.UseVisualStyleBackColor = true;
            deleteCliente_btn.Click += deleteCliente_btn_Click;
            // 
            // editLeitor_btn
            // 
            editLeitor_btn.Location = new Point(240, 412);
            editLeitor_btn.Name = "editLeitor_btn";
            editLeitor_btn.Size = new Size(571, 23);
            editLeitor_btn.TabIndex = 36;
            editLeitor_btn.Text = "Editar";
            editLeitor_btn.UseVisualStyleBackColor = true;
            editLeitor_btn.Click += editLeitor_btn_Click_1;
            // 
            // search_Leitores_dataGridView
            // 
            search_Leitores_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            search_Leitores_dataGridView.Location = new Point(240, 18);
            search_Leitores_dataGridView.Margin = new Padding(2, 1, 2, 1);
            search_Leitores_dataGridView.Name = "search_Leitores_dataGridView";
            search_Leitores_dataGridView.RowHeadersWidth = 82;
            search_Leitores_dataGridView.Size = new Size(571, 365);
            search_Leitores_dataGridView.TabIndex = 35;
            // 
            // saveLeitor_btn
            // 
            saveLeitor_btn.Location = new Point(240, 386);
            saveLeitor_btn.Margin = new Padding(2, 1, 2, 1);
            saveLeitor_btn.Name = "saveLeitor_btn";
            saveLeitor_btn.Size = new Size(571, 22);
            saveLeitor_btn.TabIndex = 34;
            saveLeitor_btn.Text = "Guardar";
            saveLeitor_btn.UseVisualStyleBackColor = true;
            saveLeitor_btn.Click += saveLeitor_btn_Click_1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(2, 79);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(49, 15);
            label13.TabIndex = 33;
            label13.Text = "Critério:";
            // 
            // searchLeitorParameter_ComboBox
            // 
            searchLeitorParameter_ComboBox.FormattingEnabled = true;
            searchLeitorParameter_ComboBox.Location = new Point(2, 96);
            searchLeitorParameter_ComboBox.Margin = new Padding(2, 1, 2, 1);
            searchLeitorParameter_ComboBox.Name = "searchLeitorParameter_ComboBox";
            searchLeitorParameter_ComboBox.Size = new Size(183, 23);
            searchLeitorParameter_ComboBox.TabIndex = 32;
            // 
            // clearLeitorSearch_btn
            // 
            clearLeitorSearch_btn.Location = new Point(2, 200);
            clearLeitorSearch_btn.Name = "clearLeitorSearch_btn";
            clearLeitorSearch_btn.Size = new Size(181, 23);
            clearLeitorSearch_btn.TabIndex = 31;
            clearLeitorSearch_btn.Text = "Limpar";
            clearLeitorSearch_btn.UseVisualStyleBackColor = true;
            clearLeitorSearch_btn.Click += clearLeitorSearch_btn_Click;
            // 
            // pesquisarLeitorSearch_btn
            // 
            pesquisarLeitorSearch_btn.Location = new Point(2, 171);
            pesquisarLeitorSearch_btn.Name = "pesquisarLeitorSearch_btn";
            pesquisarLeitorSearch_btn.Size = new Size(181, 23);
            pesquisarLeitorSearch_btn.TabIndex = 30;
            pesquisarLeitorSearch_btn.Text = "Pesquisar";
            pesquisarLeitorSearch_btn.UseVisualStyleBackColor = true;
            pesquisarLeitorSearch_btn.Click += pesquisarLeitorSearch_btn_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(2, 120);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(43, 15);
            label14.TabIndex = 29;
            label14.Text = "Termo:";
            // 
            // searchLeitor_txtbox
            // 
            searchLeitor_txtbox.Location = new Point(2, 136);
            searchLeitor_txtbox.Margin = new Padding(2, 1, 2, 1);
            searchLeitor_txtbox.Name = "searchLeitor_txtbox";
            searchLeitor_txtbox.Size = new Size(183, 23);
            searchLeitor_txtbox.TabIndex = 28;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(2, 39);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(33, 15);
            label15.TabIndex = 27;
            label15.Text = "Tipo:";
            // 
            // typeLeitorSearch_comboBox
            // 
            typeLeitorSearch_comboBox.FormattingEnabled = true;
            typeLeitorSearch_comboBox.Location = new Point(2, 55);
            typeLeitorSearch_comboBox.Margin = new Padding(2, 1, 2, 1);
            typeLeitorSearch_comboBox.Name = "typeLeitorSearch_comboBox";
            typeLeitorSearch_comboBox.Size = new Size(183, 23);
            typeLeitorSearch_comboBox.TabIndex = 26;
            // 
            // return_Books_TabPage
            // 
            return_Books_TabPage.Controls.Add(relatorioMultas_btn);
            return_Books_TabPage.Controls.Add(relatorioMultas_dgv);
            return_Books_TabPage.Controls.Add(relatorioEmprestimos_btn);
            return_Books_TabPage.Controls.Add(relatorioEmprestimos_dgv);
            return_Books_TabPage.Location = new Point(4, 24);
            return_Books_TabPage.Name = "return_Books_TabPage";
            return_Books_TabPage.Size = new Size(936, 545);
            return_Books_TabPage.TabIndex = 3;
            return_Books_TabPage.Text = "Outros";
            return_Books_TabPage.UseVisualStyleBackColor = true;
            // 
            // relatorioMultas_btn
            // 
            relatorioMultas_btn.Location = new Point(462, 441);
            relatorioMultas_btn.Name = "relatorioMultas_btn";
            relatorioMultas_btn.Size = new Size(411, 23);
            relatorioMultas_btn.TabIndex = 3;
            relatorioMultas_btn.Text = "Relatório de Multas";
            relatorioMultas_btn.UseVisualStyleBackColor = true;
            relatorioMultas_btn.Click += relatorioMultas_btn_Click;
            // 
            // relatorioMultas_dgv
            // 
            relatorioMultas_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            relatorioMultas_dgv.Location = new Point(465, 3);
            relatorioMultas_dgv.Name = "relatorioMultas_dgv";
            relatorioMultas_dgv.Size = new Size(408, 432);
            relatorioMultas_dgv.TabIndex = 2;
            // 
            // relatorioEmprestimos_btn
            // 
            relatorioEmprestimos_btn.Location = new Point(0, 441);
            relatorioEmprestimos_btn.Name = "relatorioEmprestimos_btn";
            relatorioEmprestimos_btn.Size = new Size(411, 23);
            relatorioEmprestimos_btn.TabIndex = 1;
            relatorioEmprestimos_btn.Text = "Relatório de Empréstimos";
            relatorioEmprestimos_btn.UseVisualStyleBackColor = true;
            relatorioEmprestimos_btn.Click += relatorioEmprestimos_btn_Click;
            // 
            // relatorioEmprestimos_dgv
            // 
            relatorioEmprestimos_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            relatorioEmprestimos_dgv.Location = new Point(3, 3);
            relatorioEmprestimos_dgv.Name = "relatorioEmprestimos_dgv";
            relatorioEmprestimos_dgv.Size = new Size(408, 432);
            relatorioEmprestimos_dgv.TabIndex = 0;
            // 
            // notificarLeitores_btn
            // 
            notificarLeitores_btn.Location = new Point(11, 441);
            notificarLeitores_btn.Name = "notificarLeitores_btn";
            notificarLeitores_btn.Size = new Size(853, 23);
            notificarLeitores_btn.TabIndex = 34;
            notificarLeitores_btn.Text = "Notificar Leitores com pagamentos em atraso";
            notificarLeitores_btn.UseVisualStyleBackColor = true;
            notificarLeitores_btn.Click += notificarLeitores_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 512);
            Controls.Add(dashboard);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            dashboard.ResumeLayout(false);
            regist_Books_TabPage.ResumeLayout(false);
            regist_Books_TabPage.PerformLayout();
            regist_Reader_TabPage.ResumeLayout(false);
            regist_Reader_TabPage.PerformLayout();
            manage_Loans_TabPage.ResumeLayout(false);
            manage_Loans_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emprestimos_dgv).EndInit();
            settings_TabPage.ResumeLayout(false);
            settings_TabPage.PerformLayout();
            search_Books_TabPage.ResumeLayout(false);
            search_Books_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)search_dataGridView).EndInit();
            search_Readers_TabPage.ResumeLayout(false);
            search_Readers_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)search_Leitores_dataGridView).EndInit();
            return_Books_TabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)relatorioMultas_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)relatorioEmprestimos_dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl dashboard;
        private TabPage regist_Books_TabPage;
        private TabPage regist_Reader_TabPage;
        private ComboBox tipo_ComboBox;
        private TextBox Titulo_txtbox;
        private TextBox Autor_txtbox;
        private TextBox Ano_txtbox;
        private TextBox ISBN_txtbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label dependsOnType_label;
        private TextBox dependsOnType_txtbox;
        private TabPage manage_Loans_TabPage;
        private TabPage return_Books_TabPage;
        private TabPage search_Books_TabPage;
        private TabPage settings_TabPage;
        private Button regist_Books_clearBtn;
        private Button regist_Books_saveBtn;
        private Button clearLeitor_btn;
        private Button guardarLeitor_btn;
        private Label dependsOnTypeLeitor_label;
        private TextBox dependsOnTypeLeitor_txtbox;
        private Label label7;
        private Label label11;
        private TextBox nomeLeitor_txtbox;
        private ComboBox tipoLeitor_ComboBox;
        private Label label8;
        private TextBox idadeLeitor_txtbox;
        private Label label6;
        private TextBox livrosRequisitados_txtbox;
        private TextBox search_txtbox;
        private Label label9;
        private ComboBox typeSearch_comboBox;
        private Button clearSearch_btn;
        private Button pesquisarSearch_btn;
        private Label label10;
        private Label label12;
        private ComboBox searchParameter_ComboBox;
        private Button saveBook_btn;
        private DataGridView search_dataGridView;
        private Button editBookSave_btn;
        private Button editBook_btn;
        private TabPage search_Readers_TabPage;
        private Button editLeitor_btn;
        private DataGridView search_Leitores_dataGridView;
        private Button saveLeitor_btn;
        private Label label13;
        private ComboBox searchLeitorParameter_ComboBox;
        private Button clearLeitorSearch_btn;
        private Button pesquisarLeitorSearch_btn;
        private Label label14;
        private TextBox searchLeitor_txtbox;
        private Label label15;
        private ComboBox typeLeitorSearch_comboBox;
        private Button editLeitor_btn1;
        private Button deleteBook_btn;
        private Button deleteCliente_btn;
        private Label label17;
        private TextBox isbnLivro_txtbox;
        private Button limparReserva_btn;
        private Button reservar_btn;
        private Label label16;
        private TextBox idLeitor_txtbox;
        private Label label18;
        private TextBox isbnLivroEmprestar_txtbox;
        private Button devolver_btn;
        private Button emprestar_Btn;
        private Label label19;
        private TextBox idLeitorEmprestar_txtbox;
        private Button pesquisarEmprestimosLeitor_btn;
        private DataGridView emprestimos_dgv;
        private Button relatorioEmprestimos_btn;
        private DataGridView relatorioEmprestimos_dgv;
        private Button relatorioMultas_btn;
        private DataGridView relatorioMultas_dgv;
        private Label label20;
        private TextBox diasProrrogar_txtbox;
        private Button prorrogar_btn;
        private Button notificarLeitores_btn;
    }
}
