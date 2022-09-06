namespace Aula_03.Modelos
{
    internal class Estudante
    {
        public string RA { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }

        public bool EhValido { get {
                return !string.IsNullOrEmpty(RA) && !string.IsNullOrEmpty(Nome);  
            }
        }
    }
}
