namespace Aula02_POO_Introducao_Linguagem_C.Dominio.Compartilhados
{
    internal class Endereco
    {
        public Endereco(string rua = "", string numero = "")
        {
            Rua = rua;
            Numero = numero;
        }
        public string Rua { get; set; }
        public string Numero { get; set; }

        public override string ToString()
        {
            return $"[Rua: {Rua},{Numero}]";
        }
    }
}
