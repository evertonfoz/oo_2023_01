using Aula02_Exercicio.Dominio;

namespace Aula02_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new();
            try
            {
                funcionario.SalarioBruto = 1000;
                Console.WriteLine(funcionario.SalarioBruto);
                Console.WriteLine(funcionario.DescontoINSS);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            } 
        }
    }
}