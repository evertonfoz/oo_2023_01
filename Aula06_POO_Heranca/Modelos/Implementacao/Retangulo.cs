namespace Aula06_POO_Heranca.Modelos.Implementacao
{
    internal class Retangulo : Forma
    {
        public double Altura { get; set; }
        public double Largura { get; set; }
        public Retangulo(string nome) : base(nome)
        {

        }
        public override double ObterArea()
        {
            base.ObterArea();
            return Altura*Largura;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
