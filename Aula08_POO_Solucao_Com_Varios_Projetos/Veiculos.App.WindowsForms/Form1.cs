using System.Data.SqlClient;
using Veiculos.Dados;
using Veiculos.Modelo;
using Veiculos.Modelo.Interfaces;

namespace Veiculos.App.WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarcaModelo marca = new("Fiat");


            try
            {
                IRepositorio repositorio = new RepositorioEF();

                repositorio.Registrar(marca);

                MessageBox.Show("OK");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Erro: {exception.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                IRepositorio repositorio = new RepositorioEF();
                

                dgvMarcas.DataSource = repositorio.ObterTodos();

                MessageBox.Show("OK");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Erro: {exception.Message}");
            }
        }
    }
}