namespace Aula06_POO_Heranca.Modelos.Implementacao
{
    internal class Forma:IForma
    {
        private string _nome;

        protected string Nome
        {
            get { return _nome; }
            private set { _nome = value; }
        }
        public Forma(string nome)
        {
            _nome = nome;
        }

        public virtual double ObterArea()
        {
            Console.WriteLine("Estou na superclasse");
            return 0;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
