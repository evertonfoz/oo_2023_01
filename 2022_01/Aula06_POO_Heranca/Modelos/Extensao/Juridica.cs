namespace Aula06_POO_Heranca.Modelos
{
    internal sealed class Juridica 
    {
        public string Cnpj { get; set; }
        public Repositorio Repositorio { get; set; }
        public void Registrar(object obj)
        {
            Repositorio.Registrar(obj);
        }
        public void Remover(object obj)
        {
            Repositorio.Remover(obj);
        }
    }
}
