using Aula03_POO_Associações_Windows_Forms.Controladores;
using POO.Validadores;
using System.ComponentModel;

namespace Aula03_POO_Associações_Windows_Forms.Apresentacao
{
    public partial class EstudanteForm : Form
    {
        public EstudanteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pressedButton = MessageBox.Show(
                tbRegistroAcademico.Text,
                "Informação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            if (pressedButton == DialogResult.OK)
            {
                MessageBox.Show("OK");
            }
        }

        private void tbRegistroAcademico_KeyPress(object sender, KeyPressEventArgs e)
        {
            var teste = Numericos.EhNumerico(e.KeyChar);
            if (!Numericos.EhNumerico(e.KeyChar))
            {
                e.Handled = true;
                lbErro.Text = "Apenas números";
            }
            else if (!Strings.LengthLessEquals(
                    tbRegistroAcademico.Text, 6))
            {
                e.Handled = true;
                lbErro.Text = "Máximo de 7 caracteres";
            }

            lbErro.Visible = e.Handled;
        }

        private void tbRegistroAcademico_TextChanged(object sender, EventArgs e)
        {
            btGravar.Enabled = EstudanteController.
                RegistroAcademicoEhValido(
                    tbRegistroAcademico.Text);
        }
    }
}
