using Aula_03.Modelos;
using System.Windows.Forms;

namespace Aula_03
{
    public partial class Form1 : Form
    {
        List<Estudante> estudantes = new();
        Estudante? estudanteAtual;

        public Form1()
        {
            InitializeComponent();
        }

        private Estudante instanciarEstudanteAtual(string ra, string nome)
        {
            return new Estudante()
            {
                RA = ra,
                Nome = nome
            };
        }

        private void atualizarEstudante(Estudante estudante)
        {
            var indexOf = estudantes.FindIndex(e => e.RA == estudante.RA);
            estudantes[indexOf] = estudante;
            //estudantes.RemoveAll(t => t.RA == estudante.RA);
        }

        private void adicionarEstudante(Estudante estudante)
        {
            estudantes.Add(estudante);
        }

        private void registrarEstudanteAtual(Estudante estudante)
        {
            if (!estudante.EhValido)
            {
                throw new Exception("Estudante não é válido");
            }

            if (estudanteAtual != null)
            {
                atualizarEstudante(estudante);
            }

            else
            {
                adicionarEstudante(estudante);
            }

            atualizarDataGridView();
        }

        private void atualizarDataGridView()
        {
            dgvEstudantes.DataSource = null;
            dgvEstudantes.DataSource = estudantes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Estudante estudanteInstaciado = instanciarEstudanteAtual(tbRA.Text, tbNome.Text);
                registrarEstudanteAtual(estudanteInstaciado);

                MessageBox.Show("Gravação realizada",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                inicializarFormulario();
            }       
            catch (Exception)
            {
                MessageBox.Show("Dados inválidos",
                                    "Falha",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            };
        }

        private void dgvEstudantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) { return; }

            estudanteAtual = new Estudante()
            {
                RA = dgvEstudantes.Rows[e.RowIndex].Cells[0].Value.ToString(),
                Nome = dgvEstudantes.Rows[e.RowIndex].Cells[1].Value.ToString()
            };

            tbRA.Text = estudanteAtual.RA;
            tbNome.Text = estudanteAtual.Nome;

            btRemover.Enabled = true;
        }

        private void inicializarFormulario()
        {
            tbRA.Clear();
            tbNome.Clear();

            btRemover.Enabled = false;
            estudanteAtual = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Remover o estudante?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                estudantes.RemoveAll(t => t.RA == estudanteAtual.RA);
                atualizarDataGridView();
                inicializarFormulario();
            }
        }
    }
}