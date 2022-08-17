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
            this.tbRegistroAcademico.TabIndex = 1;
            this.tbRegistroAcademico.TextChanged += new System.EventHandler(this.tbRegistroAcademico_TextChanged);
            this.tbRegistroAcademico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRegistroAcademico_KeyPress);
            // 
            // btGravar
            // 
            this.btGravar.Enabled = false;
            this.btGravar.Location = new System.Drawing.Point(155, 32);
            this.btGravar.Name = "btGravar";
            this.btGravar.Size = new System.Drawing.Size(84, 38);
            this.btGravar.TabIndex = 2;
            this.btGravar.Text = "Confirmar";
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
            // EstudanteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 107);
            this.Controls.Add(this.lbErro);
            this.Controls.Add(this.btGravar);
            this.Controls.Add(this.tbRegistroAcademico);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "EstudanteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudantes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbRegistroAcademico;
        private Button btGravar;
        private Label lbErro;
    }
}