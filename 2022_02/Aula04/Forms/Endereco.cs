using Aula_03.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_03.Forms
{
    public partial class FrmEndereco : Form
    {
        internal Endereco Endereco = new();
        public FrmEndereco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Endereco.Rua = txbRua.Text;

            Close();
        }
    }
}
