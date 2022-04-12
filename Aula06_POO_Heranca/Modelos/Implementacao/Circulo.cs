namespace Aula06_POO_Heranca.Modelos.Implementacao
{
    internal class Circulo : Forma
    {
        public Circulo(string nome) : base(nome)
        {
        }

        public double Raio { get; set; }

        public override double ObterArea()
        {
            return Math.Pow(Raio, 2) * Math.PI;
        }
    }
}
