using Aula03_POO_Associações_Windows_Forms.Controladores;
using Aula03_POO_Associações_Windows_Forms.Dominio;
using Aula03_POO_Associações_Windows_Forms.Dominio.Compartilhados;
using POO.Validadores;
using System.ComponentModel;

namespace Aula03_POO_Associações_Windows_Forms.Apresentacao
{
    public partial class EstudanteForm : Form
    {
        private EstudanteModel _estudanteModel = new EstudanteModel();
        private Endereco _enderecoSelecionadoNoGrid;

        public EstudanteForm()
        {
            InitializeComponent();
        }

        #region Métodos privados
        private void _inicializarAcademico()
        {
            _estudanteModel.RegistroAcademico = tbRegistroAcademico.Text;
            _estudanteModel.Nome = tbNome.Text;
        }

        private void _registrarEndereco()
        {
            Endereco endereco = new Endereco()
            {
                Rua = tbRua.Text,
                Numero = tbNumero.Text
            };

            //Endereco endereco1 = new Endereco()
            //{
            //    Rua = tbRua.Text,
            //    Numero = tbNumero.Text
            //};

            //var teste = endereco.Equals(endereco1);

            if (_estudanteModel.Enderecos == null)
            {
                _estudanteModel.Enderecos = new List<Endereco>();
            }

            if (!_estudanteModel.Enderecos.Contains(endereco))
            {
                if (_enderecoSelecionadoNoGrid != null)
                {
                    _estudanteModel.Enderecos.Remove(_enderecoSelecionadoNoGrid);
                }
                _estudanteModel.Enderecos.Add(endereco);
                _atualizarDataGridView();
            }
        }

        private void _registrarEnderecoSelecionado(DataGridViewCellEventArgs e)
        {
            _enderecoSelecionadoNoGrid = new Endereco()
            {
                Rua = dgEnderecos.
                Rows[e.RowIndex].Cells[0].Value.ToString(),
                Numero = dgEnderecos.
                Rows[e.RowIndex].Cells[1].Value.ToString()
            };

            tbRua.Text = _enderecoSelecionadoNoGrid.Rua;
            tbNumero.Text = _enderecoSelecionadoNoGrid.Numero;
        }

        private void _atualizarDataGridView()
        {
            dgEnderecos.DataSource = null;
            dgEnderecos.DataSource = _estudanteModel.Enderecos;

            tbRua.Clear();
            tbNumero.Clear();

            dgEnderecos.ClearSelection();
        }
        #endregion

        #region Eventos
        private void button1_Click(object sender, EventArgs e)
        {
            //EstudanteModel estudanteModel = new EstudanteModel()
            //{
            //    Nome = tbNome.Text,
            //    RegistroAcademico = tbRegistroAcademico.Text,
            //    //Endereco = new Endereco()
            //    //{
            //    //    Rua = tbRua.Text,
            //    //    Numero = tbNumero.Text,
            //    //}
            //};

            var pressedButton = MessageBox.Show(
                tbRegistroAcademico.Text,
                "Informação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            //if (pressedButton == DialogResult.OK)
            //{
            //    MessageBox.Show("OK");
            //}
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

        private void EstudanteForm_Shown(object sender, EventArgs e)
        {
            tbNome.Focus();
        }

        private void btRegistrarEndereco_Click(object sender, EventArgs e)
        {
            _inicializarAcademico();
            _registrarEndereco();
        }
        #endregion

        private void dgEnderecos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _registrarEnderecoSelecionado(e);
        }

        private void btRemoverEndereco_Click(object sender, EventArgs e)
        {
            _estudanteModel.Enderecos.Remove(_enderecoSelecionadoNoGrid);
            _atualizarDataGridView();
        }
    }
}
