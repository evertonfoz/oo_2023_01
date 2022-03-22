using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void tbRegistroAcademico_KeyUp(object sender, KeyEventArgs e)
        {
            //char keyValue = e.KeyData.
            //    ToString().ToCharArray()[0];
            //bool ehValido = !char.IsLetter(keyValue);

            //if (!ehValido)
            //{
            //    e .SuppressKeyPress = false;
            //}

            //Console.WriteLine(e);

        }

        private void tbRegistroAcademico_Validating(object sender, CancelEventArgs e)
        {
           //char keyValue = tbRegistroAcademico.Text.ToCharArray()[0];
           // bool ehValido = !char.IsLetter(keyValue);

           // if (!ehValido)
           // {
           //     e.Cancel = true;
           // }

           // Console.WriteLine(e);

        }

        private void tbRegistroAcademico_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbRegistroAcademico_KeyDown(object sender, KeyEventArgs e)
        {
            //char keyValue = tbRegistroAcademico.Text.ToCharArray()[0];
            //bool ehValido = !char.IsLetter(keyValue);

            //if (!ehValido)
            //{
            //    e.Cancel = true;
            //}

            //Console.WriteLine(e);

        }

        private void tbRegistroAcademico_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled
                = "0123456789".IndexOf(e.KeyChar) == -1
                && !Char.IsControl(e.KeyChar);
        }
    }
}
