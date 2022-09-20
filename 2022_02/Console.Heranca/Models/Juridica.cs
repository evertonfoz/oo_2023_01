
namespace Console.Heranca.Models
{
    internal class Juridica : Pessoa
    {
        public Juridica(string nome, string cnpj) : base(nome)
        {
            CNPJ = cnpj;
        }

        public string CNPJ { get; set; }
        public override string ToString()
        {
            return $"[{Nome}]: [{CNPJ}]";
        }


        protected override void logDeSucesso()
        {
            System.Console.WriteLine($"{Nome} criado com sucesso");
        }
    }
}
