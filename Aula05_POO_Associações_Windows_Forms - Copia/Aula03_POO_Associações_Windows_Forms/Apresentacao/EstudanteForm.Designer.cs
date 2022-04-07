namespace Aula03_POO_Associações_Windows_Forms.Apresentacao
{
    partial class EstudanteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbRegistroAcademico = new System.Windows.Forms.TextBox();
            this.btGravar = new System.Windows.Forms.Button();
            this.lbErro = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRegistrarEndereco = new System.Windows.Forms.Button();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgEnderecos = new System.Windows.Forms.DataGridView();
            this.btRemoverEndereco = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEnderecos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro Acadêmico";
            // 
            // tbRegistroAcademico
            // 
            this.tbRegistroAcademico.Location = new System.Drawing.Point(33, 47);
            this.tbRegistroAcademico.Name = "tbRegistroAcademico";
            this.tbRegistroAcademico.Size = new System.Drawing.Size(116, 23);
            this.tbRegistroAcademico.TabIndex = 0;
            this.tbRegistroAcademico.TextChanged += new System.EventHandler(this.tbRegistroAcademico_TextChanged);
            this.tbRegistroAcademico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRegistroAcademico_KeyPress);
            // 
            // btGravar
            // 
            this.btGravar.Enabled = false;
            this.btGravar.Location = new System.Drawing.Point(113, 217);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(188, 38);
            this.btGravar.TabIndex = 4;
            this.btGravar.Text = "Registrar Acadêmico(a)";
            this.btGravar.UseVisualStyleBackColor = true;
            this.btGravar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbErro
            // 
            this.lbErro.AutoSize = true;
            this.lbErro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbErro.Location = new System.Drawing.Point(34, 72);
            this.lbErro.Name = "lbErro";
            this.lbErro.Size = new System.Drawing.Size(28, 15);
            this.lbErro.TabIndex = 3;
            this.lbErro.Text = "Erro";
            this.lbErro.Visible = false;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(164, 47);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(229, 23);
            this.tbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRemoverEndereco);
            this.groupBox1.Controls.Add(this.btRegistrarEndereco);
            this.groupBox1.Controls.Add(this.tbNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbRua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(34, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 109);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // btRegistrarEndereco
            // 
            this.btRegistrarEndereco.Location = new System.Drawing.Point(226, 65);
            this.btRegistrarEndereco.Name = "btRegistrarEndereco";
            this.btRegistrarEndereco.Size = new System.Drawing.Size(127, 38);
            this.btRegistrarEndereco.TabIndex = 9;
            this.btRegistrarEndereco.Text = "Registrar Endereço";
            this.btRegistrarEndereco.UseVisualStyleBackColor = true;
            this.btRegistrarEndereco.Click += new System.EventHandler(this.btRegistrarEndereco_Click);
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(288, 37);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(65, 23);
            this.tbNumero.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Número";
            // 
            // tbRua
            // 
            this.tbRua.Location = new System.Drawing.Point(22, 37);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(229, 23);
            this.tbRua.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Rua";
            // 
            // dgEnderecos
            // 
            this.dgEnderecos.AllowUserToAddRows = false;
            this.dgEnderecos.AllowUserToDeleteRows = false;
            this.dgEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEnderecos.Location = new System.Drawing.Point(399, 29);
            this.dgEnderecos.Name = "dgEnderecos";
            this.dgEnderecos.ReadOnly = true;
            this.dgEnderecos.RowTemplate.Height = 25;
            this.dgEnderecos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEnderecos.Size = new System.Drawing.Size(259, 226);
            this.dgEnderecos.TabIndex = 7;
            this.dgEnderecos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEnderecos_CellClick);
            // 
            // btRemoverEndereco
            // 
            this.btRemoverEndereco.Location = new System.Drawing.Point(22, 73);
            this.btRemoverEndereco.Name = "btRemoverEndereco";
            this.btRemoverEndereco.Size = new System.Drawing.Size(139, 23);
            this.btRemoverEndereco.TabIndex = 8;
            this.btRemoverEndereco.Text = "Remover endereço";
            this.btRemoverEndereco.UseVisualStyleBackColor = true;
            this.btRemoverEndereco.Click += new System.EventHandler(this.btRemoverEndereco_Click);
            // 
            // EstudanteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 258);
            this.Controls.Add(this.dgEnderecos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbErro);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.tbRegistroAcademico);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "EstudanteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudantes";
            this.Shown += new System.EventHandler(this.EstudanteForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEnderecos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbRegistroAcademico;
        private Button btGravar;
        private Label lbErro;
        private TextBox tbNome;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox tbRua;
        private Label label3;
        private TextBox tbNumero;
        private Label label4;
        private Button btRegistrarEndereco;
        private DataGridView dgEnderecos;
        private Button btRemoverEndereco;
    }
}