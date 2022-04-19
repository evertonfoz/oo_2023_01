using Veiculos.Dados;
using Veiculos.Modelo;

namespace Veiculos.App.Console
{
    class Program
    {
        static void Main(String[] args)
        {
            MarcaModelo marca = new("Fiat");

            Repositorio repositorio = new Repositorio();
            repositorio.Registrar(marca);
            System.Console.WriteLine("Registrado");
        }
    }
}
