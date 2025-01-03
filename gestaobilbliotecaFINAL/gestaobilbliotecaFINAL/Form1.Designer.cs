
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
            return_Books_TabPage = new TabPage();
            search_Books_TabPage = new TabPage();
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
            settings_TabPage = new TabPage();
            dashboard.SuspendLayout();
            regist_Books_TabPage.SuspendLayout();
            regist_Reader_TabPage.SuspendLayout();
            search_Books_TabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)search_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dashboard
            // 
            dashboard.Controls.Add(regist_Books_TabPage);
            dashboard.Controls.Add(regist_Reader_TabPage);
            dashboard.Controls.Add(manage_Loans_TabPage);
            dashboard.Controls.Add(return_Books_TabPage);
            dashboard.Controls.Add(search_Books_TabPage);
            dashboard.Controls.Add(settings_TabPage);
            dashboard.Location = new Point(22, 26);
            dashboard.Margin = new Padding(6);
            dashboard.Name = "dashboard";
            dashboard.SelectedIndex = 0;
            dashboard.Size = new Size(1753, 1222);
            dashboard.TabIndex = 0;
            // 
            // regist_Books_TabPage
            // 
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
            regist_Books_TabPage.Location = new Point(8, 46);
            regist_Books_TabPage.Margin = new Padding(6);
            regist_Books_TabPage.Name = "regist_Books_TabPage";
            regist_Books_TabPage.Padding = new Padding(6);
            regist_Books_TabPage.Size = new Size(1737, 1168);
            regist_Books_TabPage.TabIndex = 0;
            regist_Books_TabPage.Text = "Registar Livros";
            regist_Books_TabPage.UseVisualStyleBackColor = true;
            regist_Books_TabPage.Click += regist_Books_TabPage_Click;
            // 
            // regist_Books_clearBtn
            // 
            regist_Books_clearBtn.Location = new Point(14, 577);
            regist_Books_clearBtn.Margin = new Padding(6);
            regist_Books_clearBtn.Name = "regist_Books_clearBtn";
            regist_Books_clearBtn.Size = new Size(401, 49);
            regist_Books_clearBtn.TabIndex = 14;
            regist_Books_clearBtn.Text = "Limpar";
            regist_Books_clearBtn.UseVisualStyleBackColor = true;
            regist_Books_clearBtn.Click += regist_Books_clearBtn_Click;
            // 
            // regist_Books_saveBtn
            // 
            regist_Books_saveBtn.Location = new Point(14, 515);
            regist_Books_saveBtn.Margin = new Padding(6);
            regist_Books_saveBtn.Name = "regist_Books_saveBtn";
            regist_Books_saveBtn.Size = new Size(401, 49);
            regist_Books_saveBtn.TabIndex = 13;
            regist_Books_saveBtn.Text = "Guardar";
            regist_Books_saveBtn.UseVisualStyleBackColor = true;
            regist_Books_saveBtn.Click += regist_Books_saveBtn_Click;
            // 
            // dependsOnType_label
            // 
            dependsOnType_label.AutoSize = true;
            dependsOnType_label.Location = new Point(451, 6);
            dependsOnType_label.Margin = new Padding(6, 0, 6, 0);
            dependsOnType_label.Name = "dependsOnType_label";
            dependsOnType_label.Size = new Size(44, 32);
            dependsOnType_label.TabIndex = 12;
            dependsOnType_label.Text = "---";
            dependsOnType_label.Click += dependsOnType_label_Click;
            // 
            // dependsOnType_txtbox
            // 
            dependsOnType_txtbox.Location = new Point(451, 45);
            dependsOnType_txtbox.Margin = new Padding(6);
            dependsOnType_txtbox.Name = "dependsOnType_txtbox";
            dependsOnType_txtbox.Size = new Size(396, 39);
            dependsOnType_txtbox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 100);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 32);
            label5.TabIndex = 9;
            label5.Text = "Titulo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 382);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 32);
            label4.TabIndex = 8;
            label4.Text = "ISBN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 288);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 32);
            label3.TabIndex = 7;
            label3.Text = "Ano:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 194);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 6;
            label2.Text = "Autor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 32);
            label1.TabIndex = 5;
            label1.Text = "Tipo:";
            // 
            // ISBN_txtbox
            // 
            ISBN_txtbox.Location = new Point(14, 420);
            ISBN_txtbox.Margin = new Padding(6);
            ISBN_txtbox.Name = "ISBN_txtbox";
            ISBN_txtbox.Size = new Size(396, 39);
            ISBN_txtbox.TabIndex = 4;
            // 
            // Ano_txtbox
            // 
            Ano_txtbox.Location = new Point(14, 326);
            Ano_txtbox.Margin = new Padding(6);
            Ano_txtbox.Name = "Ano_txtbox";
            Ano_txtbox.Size = new Size(396, 39);
            Ano_txtbox.TabIndex = 3;
            // 
            // Autor_txtbox
            // 
            Autor_txtbox.Location = new Point(14, 232);
            Autor_txtbox.Margin = new Padding(6);
            Autor_txtbox.Name = "Autor_txtbox";
            Autor_txtbox.Size = new Size(396, 39);
            Autor_txtbox.TabIndex = 2;
            // 
            // Titulo_txtbox
            // 
            Titulo_txtbox.Location = new Point(12, 138);
            Titulo_txtbox.Margin = new Padding(6);
            Titulo_txtbox.Name = "Titulo_txtbox";
            Titulo_txtbox.Size = new Size(396, 39);
            Titulo_txtbox.TabIndex = 1;
            // 
            // tipo_ComboBox
            // 
            tipo_ComboBox.FormattingEnabled = true;
            tipo_ComboBox.Items.AddRange(new object[] { "Cientifico", "Educativo", "Ficção", "Revista", "Jornal" });
            tipo_ComboBox.Location = new Point(12, 45);
            tipo_ComboBox.Margin = new Padding(6);
            tipo_ComboBox.Name = "tipo_ComboBox";
            tipo_ComboBox.Size = new Size(396, 40);
            tipo_ComboBox.TabIndex = 0;
            tipo_ComboBox.SelectedIndexChanged += tipo_ComboBox_SelectedIndexChanged;
            // 
            // regist_Reader_TabPage
            // 
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
            regist_Reader_TabPage.Location = new Point(8, 46);
            regist_Reader_TabPage.Margin = new Padding(6);
            regist_Reader_TabPage.Name = "regist_Reader_TabPage";
            regist_Reader_TabPage.Padding = new Padding(6);
            regist_Reader_TabPage.Size = new Size(1737, 1168);
            regist_Reader_TabPage.TabIndex = 1;
            regist_Reader_TabPage.Text = "Registar Leitores";
            regist_Reader_TabPage.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 295);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(221, 32);
            label6.TabIndex = 32;
            label6.Text = "Livros Requisitados:";
            // 
            // livrosRequisitados_txtbox
            // 
            livrosRequisitados_txtbox.Location = new Point(12, 333);
            livrosRequisitados_txtbox.Margin = new Padding(6);
            livrosRequisitados_txtbox.Name = "livrosRequisitados_txtbox";
            livrosRequisitados_txtbox.Size = new Size(396, 39);
            livrosRequisitados_txtbox.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 197);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 30;
            label8.Text = "Idade:";
            // 
            // idadeLeitor_txtbox
            // 
            idadeLeitor_txtbox.Location = new Point(12, 235);
            idadeLeitor_txtbox.Margin = new Padding(6);
            idadeLeitor_txtbox.Name = "idadeLeitor_txtbox";
            idadeLeitor_txtbox.Size = new Size(396, 39);
            idadeLeitor_txtbox.TabIndex = 29;
            // 
            // clearLeitor_btn
            // 
            clearLeitor_btn.Location = new Point(12, 483);
            clearLeitor_btn.Margin = new Padding(6);
            clearLeitor_btn.Name = "clearLeitor_btn";
            clearLeitor_btn.Size = new Size(401, 49);
            clearLeitor_btn.TabIndex = 28;
            clearLeitor_btn.Text = "Limpar";
            clearLeitor_btn.UseVisualStyleBackColor = true;
            clearLeitor_btn.Click += clearLeitor_btn_Click;
            // 
            // guardarLeitor_btn
            // 
            guardarLeitor_btn.Location = new Point(12, 421);
            guardarLeitor_btn.Margin = new Padding(6);
            guardarLeitor_btn.Name = "guardarLeitor_btn";
            guardarLeitor_btn.Size = new Size(401, 49);
            guardarLeitor_btn.TabIndex = 27;
            guardarLeitor_btn.Text = "Guardar";
            guardarLeitor_btn.UseVisualStyleBackColor = true;
            guardarLeitor_btn.Click += button2_Click;
            // 
            // dependsOnTypeLeitor_label
            // 
            dependsOnTypeLeitor_label.AutoSize = true;
            dependsOnTypeLeitor_label.Location = new Point(451, 6);
            dependsOnTypeLeitor_label.Margin = new Padding(6, 0, 6, 0);
            dependsOnTypeLeitor_label.Name = "dependsOnTypeLeitor_label";
            dependsOnTypeLeitor_label.Size = new Size(44, 32);
            dependsOnTypeLeitor_label.TabIndex = 26;
            dependsOnTypeLeitor_label.Text = "---";
            // 
            // dependsOnTypeLeitor_txtbox
            // 
            dependsOnTypeLeitor_txtbox.Location = new Point(451, 45);
            dependsOnTypeLeitor_txtbox.Margin = new Padding(6);
            dependsOnTypeLeitor_txtbox.Name = "dependsOnTypeLeitor_txtbox";
            dependsOnTypeLeitor_txtbox.Size = new Size(396, 39);
            dependsOnTypeLeitor_txtbox.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 100);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 32);
            label7.TabIndex = 24;
            label7.Text = "Nome:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 6);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(66, 32);
            label11.TabIndex = 20;
            label11.Text = "Tipo:";
            // 
            // nomeLeitor_txtbox
            // 
            nomeLeitor_txtbox.Location = new Point(12, 138);
            nomeLeitor_txtbox.Margin = new Padding(6);
            nomeLeitor_txtbox.Name = "nomeLeitor_txtbox";
            nomeLeitor_txtbox.Size = new Size(396, 39);
            nomeLeitor_txtbox.TabIndex = 16;
            // 
            // tipoLeitor_ComboBox
            // 
            tipoLeitor_ComboBox.FormattingEnabled = true;
            tipoLeitor_ComboBox.Items.AddRange(new object[] { "Comum", "Professor", "Estudante", "Senior" });
            tipoLeitor_ComboBox.Location = new Point(12, 45);
            tipoLeitor_ComboBox.Margin = new Padding(6);
            tipoLeitor_ComboBox.Name = "tipoLeitor_ComboBox";
            tipoLeitor_ComboBox.Size = new Size(396, 40);
            tipoLeitor_ComboBox.TabIndex = 15;
            tipoLeitor_ComboBox.SelectedIndexChanged += tipoLeitor_ComboBox_SelectedIndexChanged;
            // 
            // manage_Loans_TabPage
            // 
            manage_Loans_TabPage.Location = new Point(8, 46);
            manage_Loans_TabPage.Margin = new Padding(6);
            manage_Loans_TabPage.Name = "manage_Loans_TabPage";
            manage_Loans_TabPage.Size = new Size(1737, 1168);
            manage_Loans_TabPage.TabIndex = 2;
            manage_Loans_TabPage.Text = "Empréstimos";
            manage_Loans_TabPage.UseVisualStyleBackColor = true;
            // 
            // return_Books_TabPage
            // 
            return_Books_TabPage.Location = new Point(8, 46);
            return_Books_TabPage.Margin = new Padding(6);
            return_Books_TabPage.Name = "return_Books_TabPage";
            return_Books_TabPage.Size = new Size(1737, 1168);
            return_Books_TabPage.TabIndex = 3;
            return_Books_TabPage.Text = "Devoluções";
            return_Books_TabPage.UseVisualStyleBackColor = true;
            // 
            // search_Books_TabPage
            // 
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
            search_Books_TabPage.Location = new Point(8, 46);
            search_Books_TabPage.Margin = new Padding(6);
            search_Books_TabPage.Name = "search_Books_TabPage";
            search_Books_TabPage.Size = new Size(1737, 1168);
            search_Books_TabPage.TabIndex = 4;
            search_Books_TabPage.Text = "Pesquisar";
            search_Books_TabPage.UseVisualStyleBackColor = true;
            // 
            // search_dataGridView
            // 
            search_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            search_dataGridView.Location = new Point(445, 35);
            search_dataGridView.Name = "search_dataGridView";
            search_dataGridView.RowHeadersWidth = 82;
            search_dataGridView.Size = new Size(1060, 778);
            search_dataGridView.TabIndex = 24;
            // 
            // saveBook_btn
            // 
            saveBook_btn.Location = new Point(445, 819);
            saveBook_btn.Name = "saveBook_btn";
            saveBook_btn.Size = new Size(1060, 46);
            saveBook_btn.TabIndex = 21;
            saveBook_btn.Text = "Guardar";
            saveBook_btn.UseVisualStyleBackColor = true;
            saveBook_btn.Click += saveBook_btn_Click_1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 156);
            label12.Name = "label12";
            label12.Size = new Size(97, 32);
            label12.TabIndex = 19;
            label12.Text = "Critério:";
            // 
            // searchParameter_ComboBox
            // 
            searchParameter_ComboBox.FormattingEnabled = true;
            searchParameter_ComboBox.Location = new Point(3, 191);
            searchParameter_ComboBox.Name = "searchParameter_ComboBox";
            searchParameter_ComboBox.Size = new Size(336, 40);
            searchParameter_ComboBox.TabIndex = 18;
            // 
            // clearSearch_btn
            // 
            clearSearch_btn.Location = new Point(3, 405);
            clearSearch_btn.Margin = new Padding(6);
            clearSearch_btn.Name = "clearSearch_btn";
            clearSearch_btn.Size = new Size(336, 49);
            clearSearch_btn.TabIndex = 16;
            clearSearch_btn.Text = "Limpar";
            clearSearch_btn.UseVisualStyleBackColor = true;
            clearSearch_btn.Click += clearSearch_btn_Click;
            // 
            // pesquisarSearch_btn
            // 
            pesquisarSearch_btn.Location = new Point(3, 343);
            pesquisarSearch_btn.Margin = new Padding(6);
            pesquisarSearch_btn.Name = "pesquisarSearch_btn";
            pesquisarSearch_btn.Size = new Size(336, 49);
            pesquisarSearch_btn.TabIndex = 15;
            pesquisarSearch_btn.Text = "Pesquisar";
            pesquisarSearch_btn.UseVisualStyleBackColor = true;
            pesquisarSearch_btn.Click += guardarSearch_btn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 234);
            label10.Name = "label10";
            label10.Size = new Size(86, 32);
            label10.TabIndex = 3;
            label10.Text = "Termo:";
            // 
            // search_txtbox
            // 
            search_txtbox.Location = new Point(3, 269);
            search_txtbox.Name = "search_txtbox";
            search_txtbox.Size = new Size(336, 39);
            search_txtbox.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 78);
            label9.Name = "label9";
            label9.Size = new Size(66, 32);
            label9.TabIndex = 1;
            label9.Text = "Tipo:";
            // 
            // typeSearch_comboBox
            // 
            typeSearch_comboBox.FormattingEnabled = true;
            typeSearch_comboBox.Location = new Point(3, 113);
            typeSearch_comboBox.Name = "typeSearch_comboBox";
            typeSearch_comboBox.Size = new Size(336, 40);
            typeSearch_comboBox.TabIndex = 0;
            // 
            // settings_TabPage
            // 
            settings_TabPage.Location = new Point(8, 46);
            settings_TabPage.Margin = new Padding(6);
            settings_TabPage.Name = "settings_TabPage";
            settings_TabPage.Size = new Size(1737, 1168);
            settings_TabPage.TabIndex = 5;
            settings_TabPage.Text = "Outros";
            settings_TabPage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1781, 1274);
            Controls.Add(dashboard);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            dashboard.ResumeLayout(false);
            regist_Books_TabPage.ResumeLayout(false);
            regist_Books_TabPage.PerformLayout();
            regist_Reader_TabPage.ResumeLayout(false);
            regist_Reader_TabPage.PerformLayout();
            search_Books_TabPage.ResumeLayout(false);
            search_Books_TabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)search_dataGridView).EndInit();
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
    }
}
