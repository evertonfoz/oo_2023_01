namespace Aula06_POO_Heranca.Modelos
{
    internal class Fisica
    {
        public string Cpf { get; set; }
        public Repositorio Repositorio { get; set; }
        public void Registrar(object obj)
        {
            Repositorio.Registrar(obj);
        }
    }
}
