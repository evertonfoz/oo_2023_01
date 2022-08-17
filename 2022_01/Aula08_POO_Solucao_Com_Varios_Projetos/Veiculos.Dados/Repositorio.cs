using System.Data.SqlClient;
using Veiculos.Core.Erros;
using Veiculos.Modelo;
using Veiculos.Modelo.Interfaces;

namespace Veiculos.Dados
{
    public class Repositorio : IRepositorio
    {
        private readonly SqlConnection _connection;

        public Repositorio(SqlConnection connection)
        {
            _connection = connection;
        }

        public IList<MarcaModelo> ObterTodos()
        {

            IList<MarcaModelo> marcas = new List<MarcaModelo>();

            try
            {
                string sql = "SELECT MarcaID, Nome from Marcas";

                SqlCommand comando = new SqlCommand(sql, _connection);

                _connection.Open();

                using SqlDataReader rdr = comando.ExecuteReader();

                while (rdr.Read())
                {
                    MarcaModelo marca = new MarcaModelo(
                        rdr.GetString(1), marcaID: rdr.GetInt32(0));
                    marcas.Add(marca);
                }

                return marcas;
            }
            catch (ArgumentException)
            {
                throw new VeiculosException(
"Erro na conexão com a base de dados");
            }
            catch (SqlException)
            {
                throw new VeiculosException(
                    "Erro na instrução de inserção");
            }
            catch (Exception e)
            {
                throw new VeiculosException(
                    $"Erro não previsto : {e.Message}");
            }
            finally
            {
                _connection.Close();
            }
        }


        public MarcaModelo Registrar(MarcaModelo marcaModelo)
        {
            try
            {
                string sql = "INSERT INTO Marcas(Nome) VALUES(@nome)";

                SqlCommand comando = new SqlCommand(sql, _connection);
                comando.Parameters.Add(new SqlParameter("@nome",
                    marcaModelo.Nome));

                _connection.Open();
                comando.ExecuteNonQuery();

                return new MarcaModelo("Fiat");
            }
            catch (ArgumentException)
            {
                throw new VeiculosException(
"Erro na conexão com a base de dados");
            }
            catch (SqlException)
            {
                throw new VeiculosException(
                    "Erro na instrução de inserção");
            }
            catch (Exception e)
            {
                throw new VeiculosException(
                    $"Erro não previsto : {e.Message}");
            }
            finally
            {
                _connection.Close();
            }
            return new MarcaModelo("Fiat");
        }
    }
}
