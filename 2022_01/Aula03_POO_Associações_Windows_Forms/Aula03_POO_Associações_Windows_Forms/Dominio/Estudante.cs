using Aula03_POO_Associações_Windows_Forms.Dominio.Compartilhados;

namespace Aula03_POO_Associações_Windows_Forms.Dominio
{
    internal class Estudante
    {
        public string RegistroAcademico { get; set; }
        public Endereco[] Enderecos { get; set; }
    }
}
