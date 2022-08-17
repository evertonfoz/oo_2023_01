using System.Data.SqlClient;
using Veiculos.Dados;
using Veiculos.Modelo;

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
                Repositorio repositorio = new Repositorio(
                                    new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=POO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                );

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
                Repositorio repositorio = new Repositorio(
                                    new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=POO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                );

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