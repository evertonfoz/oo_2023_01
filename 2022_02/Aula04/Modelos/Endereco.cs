namespace Aula_03.Modelos
{
    internal class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string  Estado { get; set; }

        public override string ToString()
        {
            return Rua;
        }
    }
}
