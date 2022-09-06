namespace Aula_03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRA = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btnGravar = new System.Windows.Forms.Button();
            this.dgvEstudantes = new System.Windows.Forms.DataGridView();
            this.btRemover = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudantes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "R.A.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // tbRA
            // 
            this.tbRA.Location = new System.Drawing.Point(49, 19);
            this.tbRA.Name = "tbRA";
            this.tbRA.Size = new System.Drawing.Size(100, 23);
            this.tbRA.TabIndex = 2;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(217, 19);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(216, 23);
            this.tbNome.TabIndex = 3;
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(272, 57);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvEstudantes
            // 
            this.dgvEstudantes.AllowUserToAddRows = false;
            this.dgvEstudantes.AllowUserToDeleteRows = false;
            this.dgvEstudantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstudantes.Location = new System.Drawing.Point(25, 116);
            this.dgvEstudantes.Name = "dgvEstudantes";
            this.dgvEstudantes.ReadOnly = true;
            this.dgvEstudantes.RowTemplate.Height = 25;
            this.dgvEstudantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudantes.Size = new System.Drawing.Size(408, 170);
            this.dgvEstudantes.TabIndex = 5;
            this.dgvEstudantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudantes_CellClick);
            // 
            // btRemover
            // 
            this.btRemover.Enabled = false;
            this.btRemover.Location = new System.Drawing.Point(353, 57);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 6;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Informar Endereço";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(25, 83);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(38, 15);
            this.lblEndereco.TabIndex = 8;
            this.lblEndereco.Text = "label3";
            this.lblEndereco.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 298);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.dgvEstudantes);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbRA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Estudantes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbRA;
        private TextBox tbNome;
        private Button btnGravar;
        private DataGridView dgvEstudantes;
        private Button btRemover;
        private Button button2;
        private Label lblEndereco;
    }
}